using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using garage_app_entities;

namespace DAL.Repositories
{
    public class CarRepository : ProductRepository
    {
        private readonly SpecificationRepository _specificationRepository;

        public CarRepository(MyDbContext context) : base(context)
        {
            _specificationRepository = new SpecificationRepository(context);
        }

        public List<Product> GetCars()
        {
            List<Product> productsByCategory = base.GetProductsByCategory("Cars");

            foreach (Product product in productsByCategory)
            {
                FindSpecificationsForProduct(product);
            }

            return productsByCategory;
        }

        public Product FindCar(int id)
        {
            Product findProduct = base.FindProduct(id);
            this.FindSpecificationsForProduct(findProduct);
            if (findProduct.Specifications.Count == 0)
            {
                throw new ArgumentException(
                    $"Car with Id: {findProduct.Id} and name: {findProduct.Name} is not a car please use /product endpoint");
            }

            return findProduct;
        }

        public Product FindCar(string name)
        {
            Product findProduct = base.FindProduct(name);
            this.FindSpecificationsForProduct(findProduct);
            if (findProduct.Specifications.Count == 0)
            {
                throw new ArgumentException(
                    $"Car with Id: {findProduct.Id} and name: {findProduct.Name} is not a car please use /product endpoint");
            }

            return findProduct;
        }

        public void InsertCar(Product product, List<Category> categories, List<Specification> specifications)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    base.InsertProduct(product, categories);
                    foreach (Specification specification in specifications)
                    {
                        _context.Specifications.Attach(specification);
                    }

                    product.Specifications.AddRange(specifications);
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdateCar(Product product)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    base.UpdateProduct(product);

                    foreach (Specification productSpecification in product.Specifications)
                    {
                        _specificationRepository.UpdateSpecification(productSpecification);
                    }

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DeleteCar(int productId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Product findProduct = base.FindProduct(productId);
                    findProduct.Specifications = _specificationRepository.FindSpecificationsForProduct(productId);

                    int specificationsCount = findProduct.Specifications.Count;
                    // inverse loop through the list and remove the specification if there is no other product using that specification
                    for (int i = specificationsCount - 1; i >= 0; i--)
                    {
                        Specification specification = findProduct.Specifications[i];
                        List<Product> findProductsForSpecification =
                            _specificationRepository.FindProductsForSpecification(specification.Id);
                        if (findProductsForSpecification.Count == 1)
                        {
                            _specificationRepository.DeleteSpecification(findProduct.Specifications.First().Id);
                        }
                    }

                    base.DeleteProduct(productId);
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void FindSpecificationsForProduct(Product product)
        {
            product.Specifications = _context.Products
                .Include("Specifications")
                .First(p => p.Id == product.Id)
                .Specifications;

            foreach (Specification productSpecification in product.Specifications)
            {
                productSpecification.SpecificationType = _specificationRepository
                    .FindSpecification(productSpecification.SpecificationTypeId).SpecificationType;
            }
        }
    }
}
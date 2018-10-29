using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
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
                throw new ArgumentException($"Car with Id: {findProduct.Id} and name: {findProduct.Name} is not a car please use /product endpoint");
            }
            return findProduct;
        }

        public Product FindCar(string name)
        {
            Product findProduct = base.FindProduct(name);
            this.FindSpecificationsForProduct(findProduct);
            if (findProduct.Specifications.Count == 0)
            {
                throw new ArgumentException($"Car with Id: {findProduct.Id} and name: {findProduct.Name} is not a car please use /product endpoint");
            }
            return findProduct;
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
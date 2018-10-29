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
                product.Specifications = _context.Products
                    .Include("Specifications")
                    .First(p => p.Id == product.Id)
                    .Specifications;

                foreach (Specification productSpecification in product.Specifications)
                {
                    productSpecification.SpecificationType = _specificationRepository.FindSpecification(productSpecification.SpecificationTypeId).SpecificationType;
                }
            }
            

            return productsByCategory;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using garage_app_entities;

namespace DAL.Repositories
{
    public class SpecificationRepository
    {
        private readonly MyDbContext _context;
        private readonly SpecificationTypeRepository _specificationTypeRepository;

        public SpecificationRepository(MyDbContext context)
        {
            _context = context;
            _specificationTypeRepository = new SpecificationTypeRepository(context);
        }

        public int InsertSpecification(Specification specification)
        {
            Specification specificationWithSameValueAndTypeIdCombination = _context.Specifications.FirstOrDefault(s =>
                s.Value == specification.Value && s.SpecificationTypeId == specification.SpecificationTypeId);
            if (specificationWithSameValueAndTypeIdCombination != null)
            {
                throw new ArgumentException(
                    $"specification with value {specification.Value} and specificationTypeId: {specification.SpecificationTypeId} already exists");
            }

            _context.SpecificationTypes.Attach(specification.SpecificationType);
            specification.SpecificationType.Specifications.Add(specification);
            _context.SaveChanges();
            var find = _context.Specifications.First(s =>
                s.Value == specification.Value && s.SpecificationTypeId == specification.SpecificationTypeId);
            return find.Id;
        }

        public List<Specification> GetSpecifications()
        {
            return _context.Specifications.Include("SpecificationType").ToList();
        }

        public Specification FindSpecification(int id)
        {
            return _context.Specifications.Include("SpecificationType")
                .FirstOrDefault(specification => specification.Id == id);
        }

        public List<Product> FindProductsForSpecification(int id)
        {
            return _context.Specifications.Include("Products").First(specification => specification.Id == id).Products;
        }
        public Specification FindSpecification(int specificationTypeId, string specificationValue)
        {
            return _context.Specifications.Include("SpecificationType")
                .FirstOrDefault(specification =>
                    specification.SpecificationTypeId == specificationTypeId &&
                    specification.Value == specificationValue);
        }

        public List<Specification> FindSpecificationsForProduct(int productId)
        {
            Product findProduct = _context.Products.Include("Specifications")
                .FirstOrDefault(p => p.Id == productId);
            if (findProduct == null)
            {
                throw new ArgumentException("Product was not found");
            }

            foreach (Specification findProductSpecification in findProduct.Specifications)
            {
                int index = findProduct.Specifications.FindIndex(specification =>
                    specification.Id == findProductSpecification.Id);

                findProduct.Specifications[index].SpecificationType =
                    _specificationTypeRepository.FindSpecificationType(findProductSpecification.SpecificationTypeId);
            }
            
            return findProduct.Specifications;
        }

        public void UpdateSpecification(Specification specification)
        {
            _context.Specifications.Attach(specification);
            _context.SpecificationTypes.Attach(specification.SpecificationType);
            _context.Entry(specification).State = EntityState.Modified;

            _context.SpecificationTypes.Attach(specification.SpecificationType);

            _context.SaveChanges();
        }

        public void DeleteSpecification(int id)
        {
            Specification specificationFromDb = _context.Specifications.Find(id);
            if (specificationFromDb != null)
            {
                _context.Specifications.Remove(specificationFromDb);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("specification was not found!");
            }
        }
    }
}
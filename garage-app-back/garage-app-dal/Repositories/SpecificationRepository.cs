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

        public SpecificationRepository(MyDbContext context)
        {
            _context = context;
        }

        public int InsertSpecification(Specification specification)
        {
            _context.Specifications.Add(specification);
            _context.SaveChanges();
            // todo debug this possible nullreference
            var find = _context.Specifications.Find(specification);
            return find.Id;
        }

        public List<Specification> GetSpecifications()
        {
            return _context.Specifications.ToList();
        }

        public Specification FindSpecification(int id)
        {
            return _context.Specifications.Find(id);
        }

        public void UpdateSpecification(Specification specification)
        {
            _context.Specifications.Attach(specification);
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
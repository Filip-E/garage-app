using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using garage_app_entities;

namespace DAL.Repositories
{
    class SpecificationRepository
    {
        private readonly MyDbContext _context;

        public SpecificationRepository(MyDbContext context)
        {
            _context = context;
        }

        public void InsertSpecification(Specification specification)
        {
            _context.Specifications.Add(specification);
            _context.SaveChanges();
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
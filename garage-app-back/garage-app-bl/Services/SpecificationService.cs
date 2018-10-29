using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    class SpecificationService
    {
        private readonly SpecificationRepository _repository;

        public SpecificationService()
        {
            _repository = new SpecificationRepository(new MyDbContext());
        }

        public int InsertSpecification(Specification specification)
        {
            HasRequiredProps(specification, false);
            return _repository.InsertSpecification(specification);
        }

        public List<Specification> GetSpecifications()
        {
            return _repository.GetSpecifications();
        }

        public Specification FindSpecification(int id)
        {
            return _repository.FindSpecification(id);
        }

        public void UpdateSpecification(Specification specification)
        {
            HasRequiredProps(specification, true);
            _repository.UpdateSpecification(specification);
        }

        public void DeleteSpecification(int id)
        {
            _repository.DeleteSpecification(id);
        }

        private static void HasRequiredProps(Specification specification, bool isIdRequired)
        {
            if (isIdRequired)
            {
                if (specification.Id.Equals(null))
                {
                    throw new ArgumentException("Specification Id attribute can not be null");
                }
            }

            if (specification.Value.Equals(null))
            {
                throw new ArgumentException("Specification Value attribute can not be null");
            }
        }
    }
}
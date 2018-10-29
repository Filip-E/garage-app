using System;
using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class SpecificationService
    {
        private readonly SpecificationRepository _specificationRepository;
        private readonly SpecificationTypeRepository _specificationTypeRepository;

        public SpecificationService()
        {
            _specificationRepository = new SpecificationRepository(new MyDbContext());
            _specificationTypeRepository = new SpecificationTypeRepository(new MyDbContext());
        }

        public int InsertSpecification(Specification specification)
        {
            HasRequiredProps(specification, false);
            specification.SpecificationType =
                _specificationTypeRepository.FindSpecificationType(specification.SpecificationTypeId);
            return _specificationRepository.InsertSpecification(specification);
        }

        public List<Specification> GetSpecifications()
        {
            return _specificationRepository.GetSpecifications();
        }

        public Specification FindSpecification(int id)
        {
            Specification findSpecification = _specificationRepository.FindSpecification(id);
            if (findSpecification != null)
            {
                return findSpecification;
            }
            else
            {
                throw new ArgumentException($"Specification with Id: {id} was not found");
            }
        }

        public void UpdateSpecification(Specification specification)
        {
            HasRequiredProps(specification, true);
            specification.SpecificationType =
                _specificationTypeRepository.FindSpecificationType(specification.SpecificationTypeId);
            _specificationRepository.UpdateSpecification(specification);
        }

        public void DeleteSpecification(int id)
        {
            _specificationRepository.DeleteSpecification(id);
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
using System;
using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    class SpecificationTypeService
    {
        private readonly SpecificationTypeRepository _repository;

        public SpecificationTypeService()
        {
            _repository = new SpecificationTypeRepository(new MyDbContext());
        }

        public int InsertSpecificationType(SpecificationType specificationType)
        {
            hasRequiredProps(specificationType, false);
            SpecificationType findSpecificationType = _repository.FindSpecificationType(specificationType.Type);
            if (findSpecificationType == null)
            {
                _repository.InsertSpecificationType(specificationType);
                return (_repository.FindSpecificationType(specificationType.Type)).Id;
            }
            else
            {
                throw new ArgumentException($"Specification type: {specificationType.Type} already exists");
            }
        }

        public List<SpecificationType> GetSpecificationTypes()
        {
            return _repository.GetSpecificationTypes();
        }

        public SpecificationType FindSpecificationType(int id)
        {
            return _repository.FindSpecificationType(id);
        }

        public SpecificationType FindSpecificationType(string value)
        {
            return _repository.FindSpecificationType(value);
        }

        public void UpdateSpecificationType(SpecificationType specificationType)
        {
            hasRequiredProps(specificationType, true);
            _repository.UpdateSpecificationType(specificationType);
        }

        public void DeleteSpecificationType(int id)
        {
            _repository.DeleteSpecificationType(id);
        }

        private static void hasRequiredProps(SpecificationType specificationType, bool isIdRequired)
        {
            if (isIdRequired)
            {
                if (specificationType.Id.Equals(null))
                {
                    throw new ArgumentException("SpecificationType Id attribute can not be null");
                }
            }

            if (specificationType.Type.Equals(null))
            {
                throw new ArgumentException("SpecificationType Type attribute can not be null");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class SpecificationTypeService
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

        public List<SpecificationType> GetGetRequiredCarSpecificationTypes()
        {
            return _repository.GetRequiredCarSpecificationTypes();
        }
        public SpecificationType FindSpecificationType(int id)
        {
            SpecificationType findSpecificationType = _repository.FindSpecificationType(id);
            if (findSpecificationType != null)
            {
                return findSpecificationType;
            }
            else
            {
                throw new ArgumentException($"SpecificationType with Id: {id} was not found");
            }
        }

        public SpecificationType FindSpecificationType(string type)
        {
            SpecificationType findSpecificationType = _repository.FindSpecificationType(type);
            if (findSpecificationType != null)
            {
                return findSpecificationType;
            }
            else
            {
                throw new ArgumentException($"SpecificationType with Type: {type} was not found");
            }
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
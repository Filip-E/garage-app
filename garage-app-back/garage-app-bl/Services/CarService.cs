using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class CarService
    {
        private readonly CarRepository _carRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly SpecificationTypeRepository _specificationTypeRepository;
        private readonly SpecificationRepository _specificationRepository;

        public CarService()
        {
            MyDbContext myDbContext = new MyDbContext();
            _carRepository = new CarRepository(myDbContext);
            _categoryRepository = new CategoryRepository(myDbContext);
            _specificationTypeRepository = new SpecificationTypeRepository(myDbContext);
            _specificationRepository = new SpecificationRepository(myDbContext);
        }

        public List<Product> GetCars()
        {
            return _carRepository.GetCars();
        }

        public Product FindCar(int id)
        {
            return _carRepository.FindCar(id);
        }

        public Product FindCar(string name)
        {
            return _carRepository.FindCar(name);
        }

        public Product InsertCar(Product product, List<Specification> specifications)
        {
            CheckRequiredSpecificationTypes(specifications);

            List<Specification> updatedSpecifications = new List<Specification>();
            foreach (Specification specification in specifications)
            {
                Specification findSpecification =
                    _specificationRepository.FindSpecification(specification.SpecificationTypeId, specification.Value);

                // if specification exist: add to updated list
                if (findSpecification != null)
                {
                    updatedSpecifications.Add(findSpecification);
                }
                // if specification does not exist: insert specification and add to updated list
                else
                {
                    specification.SpecificationType = _specificationTypeRepository.FindSpecificationType(specification.SpecificationTypeId);

                    int newSpecificationId = _specificationRepository.InsertSpecification(specification);

                    Specification insertedSpecification = specification;
                    insertedSpecification.Id = newSpecificationId;

                    updatedSpecifications.Add(insertedSpecification);
                }
            }

            List<Category> categories = new List<Category>();
            Category car = _categoryRepository.FindCategory("Cars");
            categories.Add(car);

            _carRepository.InsertCar(product, categories, updatedSpecifications);

            return _carRepository.FindCar(product.Name);
        }

        public void UpdateCar(Product product)
        {
            CheckRequiredSpecificationTypes(product.Specifications);
            foreach (Specification productSpecification in product.Specifications)
            {
                SpecificationType findSpecificationType = _specificationTypeRepository.FindSpecificationType(productSpecification.SpecificationTypeId);
                int index = product.Specifications.FindIndex(specification => specification.Id == productSpecification.Id);
                product.Specifications[index].SpecificationType = findSpecificationType;
            }
            List<Category> categories = new List<Category>();
            Category car = _categoryRepository.FindCategory("Cars");
            categories.Add(car);

            _carRepository.UpdateCar(product);
        }

        public void DeleteCar(int productId)
        {
            _carRepository.DeleteCar(productId);
        }

        private void CheckRequiredSpecificationTypes(List<Specification> specifications)
        {
            List<SpecificationType> requiredSpecificationTypes = new List<SpecificationType>();
            List<string> requiredSpecificationTypeNames = new List<string>()
            {
                "Merk",
                "Model",
                "Bouwjaar",
                "Cilinderhoud",
                "Brandstoftype",
                "Kleur"
            };

            foreach (string name in requiredSpecificationTypeNames)
            {
                SpecificationType findSpecificationType =
                    _specificationTypeRepository.FindSpecificationType(name);
                requiredSpecificationTypes.Add(findSpecificationType);
            }

            foreach (SpecificationType requiredSpecificationType in requiredSpecificationTypes)
            {
                List<Specification> findAll =
                    specifications.FindAll(spec => spec.SpecificationTypeId == requiredSpecificationType.Id);
                if (findAll.Count > 1)
                {
                    throw new ArgumentException(
                        $"You can only have one of each specificationType, {requiredSpecificationType.Type} count: {findAll.Count}");
                }
            }

            // remove specificationType from the required list if it exists
            foreach (Specification specification in specifications)
            {
                requiredSpecificationTypes.RemoveAll(type => type.Id == specification.SpecificationTypeId);
            }

            // if not all the required SpecificationTypes are removed throw new ArgumentException
            if (requiredSpecificationTypes.Count != 0)
            {
                string errorMessage = "The following specifications of a car are missing: ";
                foreach (SpecificationType requiredSpecificationType in requiredSpecificationTypes)
                {
                    errorMessage += $"{requiredSpecificationType.Type}, ";
                }

                errorMessage = errorMessage.Remove(errorMessage.Length - 2);
                throw new ArgumentException(errorMessage);
            }
        }
    }
}
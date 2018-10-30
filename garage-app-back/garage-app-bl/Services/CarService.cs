using System;
using System.Collections.Generic;
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

        public CarService()
        {
            MyDbContext myDbContext = new MyDbContext();
            _carRepository = new CarRepository(myDbContext);
            _categoryRepository = new CategoryRepository(myDbContext);
            _specificationTypeRepository = new SpecificationTypeRepository(myDbContext);
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

        public void InsertCar(Product product, List<Specification> specifications)
        {
            CheckRequiredSpecificationTypes(specifications);

            List<Category> categories = new List<Category>();
            Category car = _categoryRepository.FindCategory("Cars");
            categories.Add(car);

            _carRepository.InsertCar(product, categories, specifications);
        }

        private void CheckRequiredSpecificationTypes(List<Specification> specifications)
        {
            List<string> requiredSpecificationTypes = new List<string>()
            {
                "Merk",
                "Model",
                "Bouwjaar",
                "Cilinderhoud",
                "Brandstoftype",
                "Kleur"
            };

            // remove specificationType from the required list if it exists
            foreach (Specification specification in specifications)
            {
                SpecificationType findSpecificationType =
                    _specificationTypeRepository.FindSpecificationType(specification.SpecificationTypeId);
                requiredSpecificationTypes.Remove(findSpecificationType.Type);
            }

            // if not all the required SpecificationTypes are removed throw new ArgumentException
            if (requiredSpecificationTypes.Count != 0)
            {
                string errorMessage = "The following specifications of a car are missing: ";
                foreach (string s in requiredSpecificationTypes)
                {
                    errorMessage += $"{s}, ";
                }

                errorMessage = errorMessage.Remove(errorMessage.Length - 2);
                throw new ArgumentException(errorMessage);
            }
        }
    }
}
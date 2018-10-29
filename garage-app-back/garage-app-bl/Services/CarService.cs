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

        public CarService()
        {
            _carRepository = new CarRepository(new MyDbContext());
            _categoryRepository = new CategoryRepository(new MyDbContext());
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
            List<Category> categories = new List<Category>();
            Category car = _categoryRepository.FindCategory("Cars");
            categories.Add(car);

            _carRepository.InsertCar(product,categories,specifications);
        }
    }
}
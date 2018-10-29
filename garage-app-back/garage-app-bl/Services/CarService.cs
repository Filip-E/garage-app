using System;
using System.Collections.Generic;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class CarService
    {
        private readonly CarRepository _repository;

        public CarService()
        {
            _repository = new CarRepository(new MyDbContext());
        }

        public List<Product> GetCars()
        {
            return _repository.GetCars();
        }

        public Product FindCar(int id)
        {
            return _repository.FindCar(id);
        }

        public Product FindCar(string name)
        {
            return _repository.FindCar(name);
        }
    }
}
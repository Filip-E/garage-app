﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using garage_app_bl.Services;
using garage_app_entities;
using WebApplication1.DTOs.Response;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
{
    public class CarController : ApiController
    {
        private readonly CarService _carService;
        private readonly CarsMapper _carsMapper;

        public CarController()
        {
            _carService = new CarService();
            _carsMapper = new CarsMapper();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("car")]
        public IHttpActionResult GetCars()
        {
            List<CarResponseDto> carResponseDtos = new List<CarResponseDto>();
            List<Product> products = _carService.GetCars();

            foreach (Product product in products)
            {
                carResponseDtos.Add(_carsMapper.ToDto(product));
            }

            return Ok(carResponseDtos);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("car/{productId}")]
        public IHttpActionResult GetCars(int productId)
        {
            try
            {
                Product product = _carService.FindCar(productId);
                return Ok(_carsMapper.ToDto(product));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("car/name/{productName}")]
        public IHttpActionResult GetCars(string productName)
        {
            try
            {
                Product product = _carService.FindCar(productName);
                return Ok(_carsMapper.ToDto(product));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
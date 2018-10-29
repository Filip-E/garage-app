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
    }
}
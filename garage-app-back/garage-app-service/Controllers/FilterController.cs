using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using garage_app_bl.Services;
using garage_app_entities;
using garage_app_service.DTOs.Request.Filters;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    [RoutePrefix("filter")]
    public class FilterController : ApiController
    {
        private readonly ProductService _productService;
        private readonly CarService _carService;
        private readonly SpecificationTypeService _specificationTypeService;

        private readonly ProductsMapper _productsMapper;
        private readonly CarsMapper _carsMapper;

        public FilterController()
        {
            _productService = new ProductService();
            _carService = new CarService();
            _specificationTypeService = new SpecificationTypeService();

            _productsMapper = new ProductsMapper();
            _carsMapper = new CarsMapper();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("product/categories")]
        public IHttpActionResult FilterProductBasedOnCategories(FilterBasedOnCategoriesRequestDto categoryRequestDto)
        {
            try
            {
                List<Product> productsList =
                    _productService.FilterProductBasedOnCategories(categoryRequestDto.Types,
                        categoryRequestDto.Category);
                List<ProductResponseDto> responseList = new List<ProductResponseDto>();

                foreach (Product product in productsList)
                {
                    responseList.Add(_productsMapper.ToDto(product));
                }

                return Ok(responseList);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("product/names")]
        public IHttpActionResult FilterProductBasedOnNames(FilterBasedOnNamesRequestDto namesRequestDto)
        {
            try
            {
                List<Product> productsList =
                    _productService.FilterProductBasedOnNames(namesRequestDto.Names, namesRequestDto.Category);
                List<ProductResponseDto> responseList = new List<ProductResponseDto>();

                foreach (Product product in productsList)
                {
                    responseList.Add(_productsMapper.ToDto(product));
                }

                return Ok(responseList);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("car/price")]
        public IHttpActionResult FilterCarOnPrice(FilterDecimalValues filterDecimalValues)
        {
            try
            {
                if (filterDecimalValues == null)
                {
                    return BadRequest();
                }

                if (filterDecimalValues.LowerBound == null && filterDecimalValues.UpperBound == null)
                {
                    return BadRequest("lower bound and upper bound can't both be NULL");
                }

                List<Product> filterCarsOnPrice = _carService.FilterCarsOnPrice(filterDecimalValues.LowerBound,
                    filterDecimalValues.UpperBound);

                List<CarResponseDto> responseDtos = new List<CarResponseDto>();
                foreach (Product car in filterCarsOnPrice)
                {
                    responseDtos.Add(_carsMapper.ToDto(car));
                }

                return Ok(responseDtos);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                return InternalServerError();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("car/bouwjaar")]
        public IHttpActionResult FilterCarOnBouwJaar(FilterIntValues filterIntValues)
        {
            try
            {
                if (filterIntValues == null)
                {
                    return BadRequest();
                }

                if (filterIntValues.LowerBound == null && filterIntValues.UpperBound == null)
                {
                    return BadRequest("lower bound and upper bound can't both be NULL");
                }

                List<Product> filterCarsOnBouwJaar = _carService.FilterCarsOnBouwJaar(filterIntValues.LowerBound,
                    filterIntValues.UpperBound);

                List<CarResponseDto> responseDtos = new List<CarResponseDto>();
                foreach (Product car in filterCarsOnBouwJaar)
                {
                    responseDtos.Add(_carsMapper.ToDto(car));
                }

                return Ok(responseDtos);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                return InternalServerError();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("car/specification")]
        public IHttpActionResult FilterCarOnSpecification(FilterBasedOnSpecification filterBasedOnSpecification)
        {
            try
            {
                if (filterBasedOnSpecification.SpecificationType.Equals("Bouwjaar"))
                {
                    return BadRequest("please use filter/car/bouwjaar when wanting to filter on 'Bouwjaar'");
                }

                // throws exception if not found
                _specificationTypeService.FindSpecificationType(filterBasedOnSpecification.SpecificationType);

                List<Product> filterCarsOnSpecification = _carService.FilterCarsOnSpecification(
                    filterBasedOnSpecification.SpecificationType,
                    filterBasedOnSpecification.Value);

                List<CarResponseDto> responseDtos = new List<CarResponseDto>();
                foreach (Product product in filterCarsOnSpecification)
                {
                    responseDtos.Add(_carsMapper.ToDto(product));
                }

                return Ok(responseDtos);
            }
            catch (ArgumentException argException)
            {
                return BadRequest(argException.Message);
            }
        }
    }
}
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
        
        private readonly ProductsMapper _productsMapper;
        private readonly CarsMapper _carsMapper;

        public FilterController()
        {
            _productService = new ProductService();
            _carService = new CarService();

            _productsMapper = new ProductsMapper();
            _carsMapper= new CarsMapper();
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("product/categories")]
        public IHttpActionResult FilterProductBasedOnCategories(FilterBasedOnCategoriesRequestDto categoryRequestDto)
        {
            try
            {
                List<Product> productsList =
                    _productService.FilterProductBasedOnCategories(categoryRequestDto.Types, categoryRequestDto.Category);
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

                return Ok(_carService.FilterCarsOnPrice(filterDecimalValues.LowerBound,
                    filterDecimalValues.UpperBound));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                return InternalServerError();
            }
        }
    }
}
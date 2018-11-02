using System;
using System.Collections.Generic;
using System.Web.Http;
using garage_app_bl.Services;
using garage_app_entities;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    [RoutePrefix("filter")]
    public class FilterController : ApiController
    {
        private readonly ProductService _productService;
        private readonly ProductsMapper _productsMapper;

        public FilterController()
        {
            _productService = new ProductService();
            _productsMapper = new ProductsMapper();
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("product/category/categories")]
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
    }
}
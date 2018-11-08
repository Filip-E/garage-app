using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using garage_app_bl.Services;
using garage_app_entities;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly CategoryMapper _categoryMapper;

        public CategoryController()
        {
            _productService = new ProductService();
            _categoryService = new CategoryService();
            _categoryMapper = new CategoryMapper();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("category")]
        public IHttpActionResult GetCategories()
        {
            List<CategoryResponseDto> categoryResponseDtos = new List<CategoryResponseDto>();
            foreach (Category category in _categoryService.GetCategories())
            {
                categoryResponseDtos.Add(_categoryMapper.ToDto(category));
            }

            return Ok(categoryResponseDtos);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("category/product/{productId}")]
        public IHttpActionResult GetCategoriesFromProduct(int productId)
        {
            List<CategoryResponseDto> categoryResponseDtos = new List<CategoryResponseDto>();
            List<Category> categories = _productService.GetCategoriesFromProduct(productId);
            ;
            foreach (Category category in categories)
            {
                categoryResponseDtos.Add(_categoryMapper.ToDto(category));
            }

            return Ok(categoryResponseDtos);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("category/{categoryId}")]
        public IHttpActionResult FindCategory(int categoryId)
        {
            return Ok(_categoryService.FindCategory(categoryId));
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("category")]
        public IHttpActionResult InsertCategory(InsertCategoryRequestDto productRequestDto)
        {
            Category category = _categoryMapper.ToCategory(productRequestDto);
            category.Id = _categoryService.InsertCategory(category);
            return Created($"category/{category.Id}", _categoryMapper.ToDto(category));
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("category")]
        public IHttpActionResult UpdateCategory(UpdateCategoryRequestDto updateCategoryRequestDto)
        {
            Category category = _categoryMapper.ToCategory(updateCategoryRequestDto);
            _categoryService.UpdateCategory(category);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("category/{categoryId}")]
        public IHttpActionResult DeleteCategory(int categoryId)
        {
            _categoryService.DeleteCategory(categoryId);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web.Http;
using garage_app_bl.Services;
using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
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
            try
            {
                Category category = _categoryMapper.ToCategory(productRequestDto);
                category.Id = _categoryService.InsertCategory(category);
                return Created($"category/{category.Id}", _categoryMapper.ToDto(category));
            }
            catch (ArgumentException ex)
            {

                return BadRequest(ex.Message);

            }
        }
    }
}

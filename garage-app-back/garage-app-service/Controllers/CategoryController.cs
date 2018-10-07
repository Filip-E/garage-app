﻿using System.Collections.Generic;
using System.Web.Http;
using garage_app_bl.Services;
using garage_app_entities;
using WebApplication1.DTOs.Response;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ProductService _service;
        private readonly CategoryMapper _categoryMapper;

        public CategoryController()
        {
            _service = new ProductService();
            _categoryMapper = new CategoryMapper();
        }
        public IHttpActionResult GetCategoriesFromProduct(int productId)
        {
            List<CategoryResponseDto> categoryResponseDtos = new List<CategoryResponseDto>();
            List<Category> categories = _service.GetCategoriesFromProduct(productId);
            ;
            foreach (Category category in categories)
            {
                categoryResponseDtos.Add(_categoryMapper.ToDto(category));
            }

            return Ok(categoryResponseDtos);
        }
    }
}
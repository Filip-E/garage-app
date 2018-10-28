using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;

namespace WebApplication1.Mappers
{
    public class CategoryMapper
    {
        public CategoryResponseDto ToDto(Category category)
        {
            return new CategoryResponseDto()
            {
                Id = category.Id,
                Type = category.Type
            };
        }

        public Category ToCategory(InsertCategoryRequestDto insertCategoryRequestDto)
        {
            return new Category()
            {
                Type = insertCategoryRequestDto.Type
            };
        }

        public Category ToCategory(UpdateCategoryRequestDto updateCategoryRequestDto)
        {
            return new Category()
            {
                Id = updateCategoryRequestDto.Id,
                Type = updateCategoryRequestDto.Type
            };
        }
    }
}
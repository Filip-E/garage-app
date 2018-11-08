using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using garage_app_entities;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;

namespace garage_app_service.Mappers
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
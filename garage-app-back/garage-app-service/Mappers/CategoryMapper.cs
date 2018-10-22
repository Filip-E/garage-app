using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using garage_app_entities;
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
    }
}
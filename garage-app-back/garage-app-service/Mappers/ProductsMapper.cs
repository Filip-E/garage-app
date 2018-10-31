using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using garage_app_entities;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;

namespace garage_app_service.Mappers
{
    public class ProductsMapper
    {
        public virtual ProductResponseDto ToDto(Product product)
        {
            return new ProductResponseDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }

        public Product ToProduct(InsertProductRequestDto productRequestDto)
        {
            return new Product
            {
                Name = productRequestDto.Name,
                Price = productRequestDto.Price,
                Stock = productRequestDto.Stock
            };
        }

        public Product ToProduct(UpdateProductRequestDto productRequestDto)
        {
            return new Product
            {
                Id = productRequestDto.Id,
                Name = productRequestDto.Name,
                Price = productRequestDto.Price,
                Stock = productRequestDto.Stock
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;

namespace WebApplication1.Mappers
{
    public class ProductsMapper
    {
        public ProductResponseDto ToDto(Product product)
        {
            return new ProductResponseDto
            {
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
    }
}
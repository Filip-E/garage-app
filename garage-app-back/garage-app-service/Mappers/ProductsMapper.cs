using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DTOs.Response;

namespace WebApplication1.Mappers
{
    public class ProductsMapper
    {
        public ProductResponseDTO ToDto(Product product)
        {
            ProductResponseDTO dto = new ProductResponseDTO
            {
                Name = product.Name, Price = product.Price, Stock = product.Stock
            };

            return dto;
        }
    }
}
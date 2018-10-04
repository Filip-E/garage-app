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
        public ProductResponseDTO ToDTO(Product product)
        {
            ProductResponseDTO dto = new ProductResponseDTO();

            dto.Name = product.Name;
            dto.Price = product.Price;
            dto.Stock = product.Stock;
            return dto;
        }
    }
}
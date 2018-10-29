using System.Collections.Generic;
using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;

namespace WebApplication1.Mappers
{
    public class CarsMapper: ProductsMapper
    {
        private readonly SpecificationMapper _specificationMapper;

        public CarsMapper()
        {
            _specificationMapper = new SpecificationMapper();
        }
        public new CarResponseDto ToDto(Product product)
        {
            List<SpecificationResponseDto> specificationResponseDtos = new List<SpecificationResponseDto>();

            foreach (Specification productSpecification in product.Specifications)
            {
                specificationResponseDtos.Add(_specificationMapper.ToDto(productSpecification));
            }

            return new CarResponseDto()
            {
                Product = base.ToDto(product),
                Specifications = specificationResponseDtos
            };
        }

        public Product ToProduct(InsertCarRequestDto carRequestDto)
        {
            return new Product()
            {
                Name = carRequestDto.Name,
                Price = carRequestDto.Price,
                Stock = carRequestDto.Stock
            };
        }
    }
}
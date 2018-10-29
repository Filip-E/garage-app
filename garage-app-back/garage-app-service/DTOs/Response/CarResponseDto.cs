using System.Collections.Generic;

namespace WebApplication1.DTOs.Response
{
    public class CarResponseDto
    {
        public ProductResponseDto Product { get; set; }

        public List<SpecificationResponseDto> Specifications { get; set; }

        public CarResponseDto()
        {
            Specifications = new List<SpecificationResponseDto>();
        }
    }
}
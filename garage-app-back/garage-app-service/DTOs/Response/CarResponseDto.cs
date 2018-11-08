using System.Collections.Generic;

namespace garage_app_service.DTOs.Response
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
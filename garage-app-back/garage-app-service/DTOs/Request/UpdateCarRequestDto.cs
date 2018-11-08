using System.Collections.Generic;

namespace garage_app_service.DTOs.Request
{
    public class UpdateCarRequestDto
    {
        public UpdateProductRequestDto Product{ get; set; }
        public List<UpdateSpecificationRequestDto> Specifications { get; set; }

    }
}
using System.Collections.Generic;

namespace WebApplication1.DTOs.Request
{
    public class UpdateCarRequestDto
    {
        public UpdateProductRequestDto Product{ get; set; }
        public List<UpdateSpecificationRequestDto> Specifications { get; set; }

    }
}
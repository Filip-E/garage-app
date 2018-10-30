using System.Collections.Generic;

namespace WebApplication1.DTOs.Request
{
    public class InsertCarRequestDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public List<InsertSpecificationRequestDto> Specifications { get; set; }
    }
}
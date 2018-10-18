using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DTOs.Request
{
    public class InsertProductRequestDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
        public string[] CategoryTypes { get; set; }
    }
}
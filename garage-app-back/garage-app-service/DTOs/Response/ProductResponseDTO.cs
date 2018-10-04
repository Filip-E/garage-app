﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DTOs.Response
{
    public class ProductResponseDTO
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
        
        public int Stock { get; set; }
    }
}
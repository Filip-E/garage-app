using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DTOs.Response
{
    public class SpecificationTypeResponseDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsRequiredForCar { get; set; }
    }
}
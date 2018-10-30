using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DTOs.Response
{
    public class SpecificationResponseDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int SpecificationTypeId { get; set; }
        public string SpecificationType { get; set; }
    }
}
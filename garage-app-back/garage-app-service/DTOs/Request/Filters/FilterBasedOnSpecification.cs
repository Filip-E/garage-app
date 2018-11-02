using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace garage_app_service.DTOs.Request.Filters
{
    public class FilterBasedOnSpecification
    {
        public string SpecificationType { get; set; }
        public string Value { get; set; }
    }
}
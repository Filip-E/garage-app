using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace garage_app_service.DTOs.Request.Filters
{
    public class FilterDecimalValues
    {
        public decimal? LowerBound { get; set; }
        public decimal? UpperBound { get; set; }

    }
}
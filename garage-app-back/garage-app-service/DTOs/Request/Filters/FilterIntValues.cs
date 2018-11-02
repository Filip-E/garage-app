using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace garage_app_service.DTOs.Request.Filters
{
    public class FilterIntValues
    {
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
    }
}
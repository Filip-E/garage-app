namespace garage_app_service.DTOs.Request.Filters
{
    public class FilterBasedOnNamesRequestDto
    {
        public string[] Names { get; set; }
        public string Category { get; set; }

    }
}
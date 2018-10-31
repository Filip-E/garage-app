namespace garage_app_service.DTOs.Request
{
    public class FilterBasedOnCategoriesRequestDto
    {
        public string[] Types { get; set; }
        public string Category { get; set; }

    }
}
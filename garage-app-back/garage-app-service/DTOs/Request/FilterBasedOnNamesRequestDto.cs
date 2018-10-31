namespace garage_app_service.DTOs.Request
{
    public class FilterBasedOnNamesRequestDto
    {
        public string[] Names { get; set; }
        public string Category { get; set; }

    }
}
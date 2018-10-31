namespace garage_app_service.DTOs.Request
{
    public class InsertSpecificationTypeRequestDto
    {
        public string Type { get; set; }
        public bool IsRequiredForCar { get; set; }
    }
}
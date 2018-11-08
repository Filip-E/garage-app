namespace garage_app_service.DTOs.Request
{
    public class UpdateSpecificationTypeRequestDto
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public bool IsRequiredForCar { get; set; }

    }
}
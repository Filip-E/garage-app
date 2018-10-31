namespace WebApplication1.DTOs.Request
{
    public class UpdateSpecificationTypeRequestDto
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public bool IsRequiredForCar { get; set; }

    }
}
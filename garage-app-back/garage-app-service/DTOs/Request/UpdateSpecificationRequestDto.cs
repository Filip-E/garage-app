namespace garage_app_service.DTOs.Request
{
    public class UpdateSpecificationRequestDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int SpecificationTypeId { get; set; }
    }
}
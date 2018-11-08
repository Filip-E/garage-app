using garage_app_entities;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;

namespace garage_app_service.Mappers
{
    public class SpecificationTypeMapper
    {
        public SpecificationTypeResponseDto ToDto(SpecificationType specificationType)
        {
            return new SpecificationTypeResponseDto()
            {
                Id = specificationType.Id,
                Type = specificationType.Type,
                IsRequiredForCar = specificationType.IsRequiredForCar
            };
        }

        public SpecificationType ToSpecificationType(InsertSpecificationTypeRequestDto requestDto)
        {
            return new SpecificationType()
            {
                Type = requestDto.Type,
                IsRequiredForCar = requestDto.IsRequiredForCar
            };
        }

        public SpecificationType ToSpecificationType(UpdateSpecificationTypeRequestDto requestDto)
        {
            return new SpecificationType()
            {
                Id = requestDto.Id,
                Type = requestDto.Type,
                IsRequiredForCar = requestDto.IsRequiredForCar
            };
        }
    }
}
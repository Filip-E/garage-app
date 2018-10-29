using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;

namespace WebApplication1.Mappers
{
    public class SpecificationMapper
    {
        public SpecificationResponseDto ToDto(Specification specification)
        {
            return new SpecificationResponseDto()
            {
                Id = specification.Id,
                Value = specification.Value,
                SpecificationTypeId = specification.SpecificationTypeId,
                SpecificationType = specification.SpecificationType.Type
            };
        }

        public Specification ToSpecification(InsertSpecificationRequestDto requestDto)
        {
            return new Specification()
            {
                Value = requestDto.Value,
                SpecificationTypeId = requestDto.SpecificationTypeId
            };
        }

        public Specification ToSpecification(UpdateSpecificationRequestDto requestDto)
        {
            return new Specification()
            {
                Id = requestDto.Id,
                Value = requestDto.Value,
                SpecificationTypeId = requestDto.SpecificationTypeId
            };
        }
    }
}
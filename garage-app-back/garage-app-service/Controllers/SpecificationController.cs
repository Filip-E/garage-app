using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using garage_app_bl.Services;
using garage_app_entities;
using garage_app_service.AuthFilter;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    public class SpecificationController : ApiController
    {
        private readonly SpecificationService _specificationService;
        private readonly SpecificationMapper _specificationMapper;

        public SpecificationController()
        {
            _specificationService = new SpecificationService();
            _specificationMapper = new SpecificationMapper();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specification")]
        public IHttpActionResult GetSpecifications()
        {
            List<SpecificationResponseDto> responseDtos = new List<SpecificationResponseDto>();
            foreach (Specification specificationType in _specificationService.GetSpecifications())
            {
                responseDtos.Add(_specificationMapper.ToDto(specificationType));
            }

            return Ok(responseDtos);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specification/{specificationId}")]
        public IHttpActionResult FindSpecification(int specificationId)
        {
            return Ok(
                _specificationMapper.ToDto(
                    _specificationService.FindSpecification(specificationId)
                )
            );
        }

        [JwtAuthentication]
        [HttpPost]
        [Route("specification")]
        public IHttpActionResult InsertSpecification(InsertSpecificationRequestDto requestDto)
        {
            Specification specificationType = _specificationMapper.ToSpecification(requestDto);
            specificationType.Id = _specificationService.InsertSpecification(specificationType);
            return Created($"specification/{specificationType.Id}",
                _specificationMapper.ToDto(specificationType));
        }


        [JwtAuthentication]
        [HttpPut]
        [Route("specification")]
        public IHttpActionResult UpdateSpecification(UpdateSpecificationRequestDto requestDto)
        {
            Specification specificationType = _specificationMapper.ToSpecification(requestDto);
            _specificationService.UpdateSpecification(specificationType);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }

        [JwtAuthentication]
        [HttpDelete]
        [Route("specification/{specificationId}")]
        public IHttpActionResult DeleteSpecification(int specificationId)
        {
            _specificationService.DeleteSpecification(specificationId);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using garage_app_bl.Services;
using garage_app_entities;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    public class SpecificationTypeController : ApiController
    {
        private readonly SpecificationTypeService _specificationTypeService;
        private readonly SpecificationTypeMapper _specificationTypeMapper;

        public SpecificationTypeController()
        {
            _specificationTypeService = new SpecificationTypeService();
            _specificationTypeMapper = new SpecificationTypeMapper();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specificationType")]
        public IHttpActionResult GetSpecificationTypes()
        {
            List<SpecificationTypeResponseDto> responseDtos = new List<SpecificationTypeResponseDto>();
            foreach (SpecificationType specificationType in _specificationTypeService.GetSpecificationTypes())
            {
                responseDtos.Add(_specificationTypeMapper.ToDto(specificationType));
            }

            return Ok(responseDtos);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specificationType/car")]
        public IHttpActionResult GetRequiredCarSpecificationTypes()
        {
            List<SpecificationTypeResponseDto> responseDtos = new List<SpecificationTypeResponseDto>();
            foreach (SpecificationType specificationType in _specificationTypeService.GetRequiredCarSpecificationTypes()
            )
            {
                responseDtos.Add(_specificationTypeMapper.ToDto(specificationType));
            }

            return Ok(responseDtos);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specificationType/{specificationTypeId}")]
        public IHttpActionResult FindSpecificationType(int specificationTypeId)
        {
            return Ok(
                _specificationTypeMapper.ToDto(
                    _specificationTypeService.FindSpecificationType(specificationTypeId)
                )
            );
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specificationType/type/{type}")]
        public IHttpActionResult FindSpecificationTypeByType(string type)
        {
            
                return Ok(
                    _specificationTypeMapper.ToDto(
                        _specificationTypeService.FindSpecificationType(type)
                    )
                );
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("specificationType")]
        public IHttpActionResult InsertSpecificationType(InsertSpecificationTypeRequestDto requestDto)
        {
                SpecificationType specificationType = _specificationTypeMapper.ToSpecificationType(requestDto);
                specificationType.Id = _specificationTypeService.InsertSpecificationType(specificationType);
                return Created($"specificationType/{specificationType.Id}",
                    _specificationTypeMapper.ToDto(specificationType));
        }


        [AllowAnonymous]
        [HttpPut]
        [Route("specificationType")]
        public IHttpActionResult UpdateSpecificationType(UpdateSpecificationTypeRequestDto requestDto)
        {
                SpecificationType specificationType = _specificationTypeMapper.ToSpecificationType(requestDto);
                _specificationTypeService.UpdateSpecificationType(specificationType);
                return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("specificationType/{specificationTypeId}")]
        public IHttpActionResult DeleteSpecificationType(int specificationTypeId)
        {
                _specificationTypeService.DeleteSpecificationType(specificationTypeId);
                return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }
    }
}
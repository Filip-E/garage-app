using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using garage_app_bl.Services;
using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
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
        [Route("specificationType/{specificationTypeId}")]
        public IHttpActionResult FindSpecificationType(int specificationTypeId)
        {
            try
            {
                return Ok(
                    _specificationTypeMapper.ToDto(
                        _specificationTypeService.FindSpecificationType(specificationTypeId)
                    )
                );
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("specificationType/type/{type}")]
        public IHttpActionResult FindSpecificationTypeByType(string type)
        {
            try
            {
                return Ok(
                    _specificationTypeMapper.ToDto(
                        _specificationTypeService.FindSpecificationType(type)
                    )
                );
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("specificationType")]
        public IHttpActionResult InsertSpecificationType(InsertSpecificationTypeRequestDto requestDto)
        {
            try
            {
                SpecificationType specificationType = _specificationTypeMapper.ToSpecificationType(requestDto);
                specificationType.Id = _specificationTypeService.InsertSpecificationType(specificationType);
                return Created($"specificationType/{specificationType.Id}",
                    _specificationTypeMapper.ToDto(specificationType));
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }


        [AllowAnonymous]
        [HttpPut]
        [Route("specificationType")]
        public IHttpActionResult UpdateSpecificationType(UpdateSpecificationTypeRequestDto requestDto)
        {
            try
            {
                SpecificationType specificationType = _specificationTypeMapper.ToSpecificationType(requestDto);
                _specificationTypeService.UpdateSpecificationType(specificationType);
                return new StatusCodeResult(HttpStatusCode.NoContent, this);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("specificationType/{specificationTypeId}")]
        public IHttpActionResult DeleteSpecificationType(int specificationTypeId)
        {
            try
            {
                _specificationTypeService.DeleteSpecificationType(specificationTypeId);
                return new StatusCodeResult(HttpStatusCode.NoContent, this);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using garage_app_bl.Services;
using garage_app_entities;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    [RoutePrefix("image")]
    public class ImageController : ApiController
    {
        private readonly ImageService _imageService;
        private readonly ImageMapper _imageMapper;
        public ImageController()
        {
            _imageService = new ImageService();
            _imageMapper = new ImageMapper();
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("product/{productId}")]
        public HttpResponseMessage InsertImage(int productId)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            try

            {
                var httpRequest = HttpContext.Current.Request;

                foreach (string file in httpRequest.Files)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);

                    var postedFile = httpRequest.Files[file];
                    if (postedFile != null && postedFile.ContentLength > 0)
                    {
                        int maxContentLength = 1024 * 1024 * 2; //Size = 2 MB  

                        IList<string> allowedFileExtensions = new List<string> { ".jpg", ".png" };
                        var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                        var extension = ext.ToLower();
                        if (!allowedFileExtensions.Contains(extension))
                        {
                            var message = "Please Upload image of type .jpg,.png.";

                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else if (postedFile.ContentLength > maxContentLength)
                        {
                            var message = "Please Upload a file up to 1 mb.";

                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else
                        {
                            var filePath =
                                HttpContext.Current.Server.MapPath("~/App_Data/" + postedFile.FileName);

                            postedFile.SaveAs(filePath);
                            Debug.WriteLine(filePath);
                            _imageService.InsertImage(productId, filePath);
                        }
                    }

                    var message1 = "Image Updated Successfully.";
                    return Request.CreateErrorResponse(HttpStatusCode.Created, message1);
                    ;
                }

                var res = "Please Upload a image.";
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
            catch (Exception ex)
            {
                dict.Add("error", ex.Message);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("product/{productId}")]
        public IHttpActionResult GetImagesFromProduct(int productId)
        {
            List<Image> imagesByProduct = _imageService.GetImagesByProduct(productId);
            List<ImageResponseDto> responseDtos = new List<ImageResponseDto>();
            foreach (Image image in imagesByProduct)
            {
                responseDtos.Add(_imageMapper.ToDto(image));
            }

            return Ok(responseDtos);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("{imageId}")]
        public IHttpActionResult DeleteImage(int imageId)
        {
            _imageService.DeleteImage(imageId);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }
    }
}
using System;
using garage_app_bl.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Security;
using garage_app_entities;
using WebApplication1.DTOs.Request;
using WebApplication1.DTOs.Response;
using WebApplication1.Filter;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductService _service;
        private readonly ProductsMapper _productsMapper;

        public ProductController()
        {
            _service = new ProductService();
            _productsMapper = new ProductsMapper();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product")]
        public IHttpActionResult GetAllProducts()
        {
            List<ProductResponseDto> response = new List<ProductResponseDto>();
            List<Product> products = _service.GetProducts();
            foreach (Product p in products)
            {
                response.Add(_productsMapper.ToDto(p));
            }

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product/{productId}")]
        public IHttpActionResult GetProduct(int productId)
        {
            try
            {
                ProductResponseDto product = _productsMapper.ToDto(_service.FindProduct(productId));
                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product/name/{productName}")]
        public IHttpActionResult GetProduct(string productName)
        {
            try
            {
                ProductResponseDto product = _productsMapper.ToDto(_service.FindProduct(productName));
                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product/category/{category}")]
        public IHttpActionResult GetProductsByCategory(string category)
        {
            try
            {
                List<Product> productsByCategory = _service.GetProductsByCategory(category);

                List<ProductResponseDto> productResponseDtos = new List<ProductResponseDto>();

                foreach (Product product in productsByCategory)
                {
                    productResponseDtos.Add(_productsMapper.ToDto(product));
                }

                return Ok(productResponseDtos);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("product")]
        public IHttpActionResult InsertProduct(InsertProductRequestDto productRequestDto)
        {
            int idInsertedProduct = -1;
            try
            {
                if (productRequestDto.CategoryTypes.Contains("Cars"))
                {
                    throw new ArgumentException(
                        "this endpoint can not be used to create products with the cars category please use /cars");
                }

                Product product = _productsMapper.ToProduct(productRequestDto);
                idInsertedProduct = _service.InsertProduct(product, productRequestDto.CategoryTypes);
                return Created($"product/productName?productName={product.Name}", _productsMapper.ToDto(product));
            }
            catch (Exception ex)
            {
                if (idInsertedProduct != -1)
                {
                    _service.DeleteProduct(idInsertedProduct);
                }

                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("product")]
        public IHttpActionResult UpdateProduct(UpdateProductRequestDto productRequestDto)
        {
            try
            {
                Product product = _productsMapper.ToProduct(productRequestDto);
                _service.UpdateProduct(product, productRequestDto.CategoryTypes);
                return new StatusCodeResult(HttpStatusCode.NoContent, this);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is NullReferenceException)
            {
                Debug.WriteLine(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("product/{productId}")]
        public IHttpActionResult DeleteProduct(int productId)
        {
            try
            {
                _service.DeleteProduct(productId);
                return new StatusCodeResult(HttpStatusCode.NoContent, this);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // todo add /filter before endpoints
        [AllowAnonymous]
        [HttpPost]
        [Route("product/category/categories")]
        public IHttpActionResult FilterProductBasedOnCategories(FilterBasedOnCategoriesRequestDto categoryRequestDto)
        {
            try
            {
                List<Product> productsList =
                    _service.FilterProductBasedOnCategories(categoryRequestDto.Types, categoryRequestDto.Category);
                List<ProductResponseDto> responseList = new List<ProductResponseDto>();

                foreach (Product product in productsList)
                {
                    responseList.Add(_productsMapper.ToDto(product));
                }

                return Ok(responseList);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("product/names")]
        public IHttpActionResult FilterProductBasedOnNames(FilterBasedOnNamesRequestDto namesRequestDto)
        {
            try
            {
                List<Product> productsList =
                    _service.FilterProductBasedOnNames(namesRequestDto.Names, namesRequestDto.Category);
                List<ProductResponseDto> responseList = new List<ProductResponseDto>();

                foreach (Product product in productsList)
                {
                    responseList.Add(_productsMapper.ToDto(product));
                }

                return Ok(responseList);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("product/image/")]
        public async Task<HttpResponseMessage> PostFile()
        {
            // Check if the request contains multipart/form-data. 
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                StringBuilder sb = new StringBuilder(); // Holds the response body 

                // Read the form data and return an async task. 
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the form data. 
                foreach (var key in provider.FormData.AllKeys)
                {
                    foreach (var val in provider.FormData.GetValues(key))
                    {
                        sb.Append($"{key}: {val}\n");
                    }
                }

                // This illustrates how to get the file names for uploaded files. 
                foreach (var file in provider.FileData)
                {
                    FileInfo fileInfo = new FileInfo(file.LocalFileName);
                    sb.Append($"Uploaded file: {fileInfo.Name} ({fileInfo.Length} bytes)\n");
                }


                return new HttpResponseMessage()
                {
                    Content = new StringContent(sb.ToString())
                };
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [Route("user/PostUserImage")]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> PostUserImage()
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
                        int MaxContentLength = 1024 * 1024 * 1; //Size = 1 MB  

                        IList<string> AllowedFileExtensions = new List<string> {".jpg", ".gif", ".png"};
                        var ext = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf('.'));
                        var extension = ext.ToLower();
                        if (!AllowedFileExtensions.Contains(extension))
                        {
                            var message = string.Format("Please Upload image of type .jpg,.gif,.png.");

                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else if (postedFile.ContentLength > MaxContentLength)
                        {
                            var message = string.Format("Please Upload a file upto 1 mb.");

                            dict.Add("error", message);
                            return Request.CreateResponse(HttpStatusCode.BadRequest, dict);
                        }
                        else
                        {
                            var filePath =
                                HttpContext.Current.Server.MapPath("~/App_Data/" + postedFile.FileName);

                            postedFile.SaveAs(filePath);
                        }
                    }

                    var message1 = string.Format("Image Updated Successfully.");
                    return Request.CreateErrorResponse(HttpStatusCode.Created, message1);
                    ;
                }

                var res = string.Format("Please Upload a image.");
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
            catch (Exception ex)
            {
                var res = string.Format("some Message");
                dict.Add("error", res);
                return Request.CreateResponse(HttpStatusCode.NotFound, dict);
            }
        }
    }
}
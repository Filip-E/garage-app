using System;
using garage_app_bl.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
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

        ProductController()
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
                Product product = _productsMapper.ToProduct(productRequestDto);
                idInsertedProduct = _service.InsertProduct(product, productRequestDto.CategoryTypes);
//                _service.AddCategoryToProduct(productRequestDto.CategoryTypes, productRequestDto.Name);
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
//                Console.WriteLine(ex.StackTrace);
                Debug.WriteLine(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [JwtAuthentication]
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
    }
}
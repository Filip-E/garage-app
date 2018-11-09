using System;
using garage_app_bl.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using garage_app_entities;
using garage_app_service.AuthFilter;
using garage_app_service.DTOs.Request;
using garage_app_service.DTOs.Response;
using garage_app_service.Mappers;

namespace garage_app_service.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductService _productService;
        private readonly ProductsMapper _productsMapper;

        public ProductController()
        {
            _productService = new ProductService();
            _productsMapper = new ProductsMapper();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product")]
        public IHttpActionResult GetAllProducts()
        {
            List<ProductResponseDto> response = new List<ProductResponseDto>();
            List<Product> products = _productService.GetProducts();
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
            ProductResponseDto product = _productsMapper.ToDto(_productService.FindProduct(productId));
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product/name/{productName}")]
        public IHttpActionResult GetProduct(string productName)
        {
            ProductResponseDto product = _productsMapper.ToDto(_productService.FindProduct(productName));
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("product/category/{category}")]
        public IHttpActionResult GetProductsByCategory(string category)
        {
            List<Product> productsByCategory = _productService.GetProductsByCategory(category);

            List<ProductResponseDto> productResponseDtos = new List<ProductResponseDto>();

            foreach (Product product in productsByCategory)
            {
                productResponseDtos.Add(_productsMapper.ToDto(product));
            }

            return Ok(productResponseDtos);
        }

        [JwtAuthentication]
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
                idInsertedProduct = _productService.InsertProduct(product, productRequestDto.CategoryTypes);
                return Created($"product/productName?productName={product.Name}", _productsMapper.ToDto(product));
            }
            catch (Exception ex)
            {
                if (idInsertedProduct != -1)
                {
                    _productService.DeleteProduct(idInsertedProduct);
                }

                return BadRequest(ex.Message);
            }
        }

        [JwtAuthentication]
        [HttpPut]
        [Route("product")]
        public IHttpActionResult UpdateProduct(UpdateProductRequestDto productRequestDto)
        {
            Product product = _productsMapper.ToProduct(productRequestDto);
            _productService.UpdateProduct(product, productRequestDto.CategoryTypes);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }

        [JwtAuthentication]
        [HttpDelete]
        [Route("product/{productId}")]
        public IHttpActionResult DeleteProduct(int productId)
        {
            _productService.DeleteProduct(productId);
            return new StatusCodeResult(HttpStatusCode.NoContent, this);
        }
    }
}
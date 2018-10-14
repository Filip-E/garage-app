using System;
using garage_app_bl.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using garage_app_entities;
using Swashbuckle.Swagger.Annotations;
using WebApplication1.DTOs.Response;
using WebApplication1.Filter;
using WebApplication1.Mappers;

namespace WebApplication1.Controllers
{
    
    public class ProductController : ApiController
    {
        private readonly ProductService  _service;
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
        [Route("product/productId")]
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
        [Route("product/category")]
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
    }
}
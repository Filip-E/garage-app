using garage_app_bl.Services;
using System.Collections.Generic;
using System.Web.Http;
using garage_app_entities;
using Swashbuckle.Swagger.Annotations;
using WebApplication1.DTOs.Response;
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


        public IHttpActionResult GetProduct(int productId)
        {
            ProductResponseDto product = _productsMapper.ToDto(_service.FindProduct(productId));
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

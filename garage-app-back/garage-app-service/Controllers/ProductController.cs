using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Repositories;

namespace WebApplication1.Controllers
{
    public class ProductController : ApiController
    {
        private ProductRepository  _repo;
        ProductController()
        {
            _repo = new ProductRepository(new DAL.MyDbContext());
        }

        public List<DAL.Product> GetAllProducts()
        {
            return _repo.getProducts();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = _repo.findProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

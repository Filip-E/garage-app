using DAL.models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace garage_app_bl.Services
{
    public class ProductService
    {
        private ProductRepository _repo;
        public ProductService()
        {
            _repo = new ProductRepository(new DAL.MyDbContext());
        }

        public List<Product> getProducts()
        {
            return _repo.GetProducts();
        }
    }
}

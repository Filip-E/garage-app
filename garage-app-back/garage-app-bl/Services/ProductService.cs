using DAL.Repositories;
using System.Collections.Generic;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class ProductService
    {
        private ProductRepository _repo;
        public ProductService()
        {
            _repo = new ProductRepository(new DAL.MyDbContext());
        }

        public List<Product> GetProducts()
        {
            return _repo.GetProducts();
        }

        public Product FindProduct(int id)
        {
            return _repo.FindProduct(id);
        }

        public List<Category> GetCategoriesFromProduct(int productId)
        {
            return _repo.GetCategoriesFromProduct(productId);
        }

        public List<Product> GetProductsByCategory(string categoryType)
        {
            return _repo.GetProductsByCategory(categoryType);
        }
    }
}

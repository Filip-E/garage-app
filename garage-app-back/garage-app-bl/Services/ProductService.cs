using System;
using DAL.Repositories;
using System.Collections.Generic;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repository;
        private readonly CategoryService _categoryService;

        public ProductService()
        {
            _repository = new ProductRepository(new DAL.MyDbContext());
            _categoryService = new CategoryService();
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

        public Product FindProduct(int id)
        {
            return _repository.FindProduct(id);
        }
        public Product FindProduct(string name)
        {
            return _repository.FindProduct(name);
        }

        public List<Category> GetCategoriesFromProduct(int productId)
        {
            return _repository.GetCategoriesFromProduct(productId);
        }

        public List<Product> GetProductsByCategory(string categoryType)
        {
            return _repository.GetProductsByCategory(categoryType);
        }

        public void InsertProduct(Product product)
        {
            HasProductRequiredProps(product, false);
            try
            {
                Product findProduct = _repository.FindProduct(product.Name);
                if (findProduct != null)
                {
                    throw new Exception($"product {product.Name} already exists");
                }
            }
            catch (ArgumentException)
            {
                _repository.InsertProduct(product);
            }
        }

        public void UpdateProduct(Product product, string[] categoryTypes)
        {
            HasProductRequiredProps(product, true);

            List<Category> categories = new List<Category>();
            foreach (string categoryType in categoryTypes)
            {
                categories.Add(_categoryService.FindCategory(categoryType));
            }

            product.Categories = categories;
            _repository.UpdateProduct(product);
        }

        public void AddCategoryToProduct(string[] categoryType, string productName)
        {
            Product findProduct = new Product();
            findProduct = _repository.FindProduct(productName);
            foreach (var type in categoryType)
            {
                Category findCategory = _categoryService.FindCategory(type);

                findProduct.Categories.Add(findCategory);
            }

            _repository.UpdateProduct(findProduct);
        }

        public void deleteProduct(int productId)
        {
            _repository.DeleteProduct(productId);
        }

        private static void HasProductRequiredProps(Product product, bool isIdRequired)
        {
            if (isIdRequired)
            {
                if (product.Id.Equals(null))
                {
                    throw new ArgumentException("name can not be null");
                }
            }
            
            if (product.Name.Equals(null))
            {
                throw new ArgumentException("name can not be null");
            }

            if (product.Price.Equals(null))
            {
                throw new ArgumentException("price can not be null");
            }

            if (product.Stock.Equals(null))
            {
                throw new ArgumentException("stock can not be null");
            }
        }
    }
}
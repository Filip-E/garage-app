using System;
using DAL.Repositories;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            return _repository.GetProductsByCategory(categoryType).ToList();
        }

        /// <summary>
        /// inserts a new product into the database
        /// </summary>
        /// <param name="product">product to be inserted</param>
        /// <returns>Id of the created product</returns>
        public int InsertProduct(Product product, string[] categoryTypes)
        {
            HasProductRequiredProps(product, false);
            try
            {
                Product findProduct = _repository.FindProduct(product.Name);
                if (findProduct != null)
                {
                    throw new Exception($"product {product.Name} already exists");
                }

                return -1;
            }
            catch (ArgumentException)
            {
                List<Category> categories = new List<Category>();
                foreach (string categoryType in categoryTypes)
                {
                    Category findCategory = _categoryService.FindCategory(categoryType);
                    Debug.WriteLine($"found category: {findCategory}");
                    categories.Add(findCategory);
                }

                _repository.InsertProduct(product, categories);
                return _repository.FindProduct(product.Name).Id;
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

        public void DeleteProduct(int productId)
        {
            _repository.DeleteProduct(productId);
        }

        public List<Product> FilterProductBasedOnCategories(string[] categories, string categoryType)
        {
            if (categories.Length == 0)
            {
                return _repository.GetProductsByCategory(categoryType).ToList();
            }
            foreach (string category in categories)
            {
                _categoryService.FindCategory(category);
            }
            return _repository.FilterProductBasedOnCategories(categories);
        }

        public List<Product> FilterProductBasedOnNames(string[] names, string categoryType)
        {
            if (names.Length == 0)
            {
                return _repository.GetProductsByCategory(categoryType).ToList();
            }
            foreach (string name in names)
            {
                this.FindProduct(name);
            }
            return _repository.FilterProductBasedOnNames(names);
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
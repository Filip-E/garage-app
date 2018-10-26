using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using garage_app_entities;

namespace DAL.Repositories
{
    public class ProductRepository
    {
        private readonly MyDbContext _context;

        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public void InsertProduct(Product product, List<Category> categories)
        {
            _context.Products.Add(product);
            foreach (Category category in categories)
            {
                _context.Categories.Attach(category);
            }
            product.Categories.AddRange(categories);
            _context.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product FindProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new ArgumentException("Product was not found!");
            }
        }

        public Product FindProduct(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name.Equals(name));
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new ArgumentException("Product was not found!");
            }
        }

        public List<Category> GetCategoriesFromProduct(int productId)
        {
            return new List<Category>(_context.Products.Where(p => p.Id == productId).SelectMany(c => c.Categories));
        }

        public List<Product> GetProductsByCategory(string categoryType)
        {
            return new List<Product>(_context.Categories.Where(c => c.Type == categoryType)
                .SelectMany(c => c.Products));
        }

        public void UpdateProduct(Product product)
        {

            // help => http://www.entityframeworktutorial.net/EntityFramework4.3/update-many-to-many-entity-using-dbcontext.aspx
            // don't forget equals implementation for objects

            var existingProduct =
                _context.Products.Include("Categories").FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                throw new ArgumentException("Product was not found");
            }

            var deleteCategories =
                existingProduct.Categories.Except(product.Categories).ToList();

            var addedCategories =
                product.Categories.Except(existingProduct.Categories).ToList();

            deleteCategories.ForEach(category => existingProduct.Categories.Remove(category));

            foreach (Category category in addedCategories)
            {
                _context.Categories.Attach(category);
                existingProduct.Categories.Add(category);
            }
            _context.SaveChanges();

            _context.DetachAllEntities();
            product.Categories.Clear();
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            Product productFromDb = _context.Products.Find(productId);
            if (productFromDb != null)
            {
                _context.Products.Remove(productFromDb);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Product was not found!");
            }
        }
    }
}
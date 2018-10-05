using System.Collections.Generic;
using System.Linq;
using garage_app_entities;

namespace DAL.Repositories
{
    public class ProductRepository
    {
        private MyDbContext _context;
        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public void InsertProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public List<Product> GetProducts()
        {
           return _context.Products.ToList();
        }

        public Product FindProduct(int id)
        {
            return _context.Products.Find(id);
        }
        public List<Category> GetCategoriesFromProduct(int productId)
        {
            return new List<Category>(_context.Products.Where(p => p.Id == productId).SelectMany(c => c.Categories));
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Product productFromDb = _context.Products.Find(id);
            _context.Products.Remove(productFromDb);
            _context.SaveChanges();
        }
    }
}

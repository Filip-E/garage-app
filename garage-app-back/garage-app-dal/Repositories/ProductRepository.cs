using DAL.models;
using System.Collections.Generic;
using System.Linq;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository
    {
        private MyDbContext _context;
        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public void createProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public List<Product> getProducts()
        {
           return _context.Products.ToList();
        }

        public Product findProduct(int id)
        {
            return _context.Products.Find(id);
        }
        public void updateProduct(Product product)
        {
            Product productFromDb = _context.Products.Find(product.Id);
            productFromDb.Name = product.Name;
            productFromDb.Price= product.Price;
            _context.SaveChanges();
        }
        public void deleteProduct(int id)
        {
            Product productFromDb = _context.Products.Find(id);
            _context.Products.Remove(productFromDb);
            _context.SaveChanges();
        }
    }
}

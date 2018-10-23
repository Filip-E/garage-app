using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using garage_app_entities;

namespace DAL.Repositories
{
    public class CategoryRepository
    {
        private readonly MyDbContext _context;

        public CategoryRepository(MyDbContext context)
        {
            _context = context;
        }

        public void InsertCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category FindCategory(int id)
        {
            return _context.Categories.Find(id);
        }

        public Category FindCategory(string type)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Type.Equals(type));
            if (category != null)
            {
                return category;
            }
            else
            {
                throw new ArgumentException($"category {type} was not found");
            }
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Attach(category);
            _context.Entry(category).State = EntityState.Modified;

            foreach (Product product in category.Products)
            {
                _context.Products.Attach(product);
            }

            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category categoryFromDb = _context.Categories.Find(id);
            if (categoryFromDb != null)
            {
                _context.Categories.Remove(categoryFromDb);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Product was not found!");
            }
        }
    }
}
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    class CategoryRepository
    {

        private MyDbContext _context;
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
        public List<Category> getCategoriesFromCategory(int id)
        {
            return _context.Categories.Find(id).Categories;
        }
        public void UpdateCategory(Category category)
        {
            _context.Categories.Attach(category);
            _context.Entry(category).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            Category categoryFromDb = _context.Categories.Find(id);
            _context.Categories.Remove(categoryFromDb);
            _context.SaveChanges();
        }
    }
}

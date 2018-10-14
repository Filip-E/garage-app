using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repositories;
using garage_app_entities;

namespace garage_app_bl.Services
{
    public class CategoryService
    {
        private CategoryRepository _repository;

        public CategoryService()
        {
            _repository = new CategoryRepository(new MyDbContext());
        }

        public List<Category> GetCategories()
        {
            return _repository.GetCategories();
        }
    }
}

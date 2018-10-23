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

        public Category FindCategory(string type)
        {
            return _repository.FindCategory(type);
        }
        public Category FindCategory(int categoryId)
        {
            return _repository.FindCategory(categoryId);
        }

        public int InsertCategory(Category category)
        {
            HasCategoryRequiredProps(category);
            try
            {
                if (_repository.FindCategory(category.Type) != null)
                {
                    throw new Exception($"category {category.Type} already exists");
                }

                return -1;
            }
            catch (ArgumentException)
            {
                _repository.InsertCategory(category);
                return (_repository.FindCategory(category.Type)).Id;
            }

        }

        public void UpdateCategory(Category category)
        {
            HasCategoryRequiredProps(category);

            _repository.UpdateCategory(category);
        }

        public void DeleteCategory(int categoryId)
        {
            _repository.DeleteCategory(categoryId);
        }

        private static void HasCategoryRequiredProps(Category category)
        {
            if (category.Id.Equals(null))
            {
                throw new ArgumentException("name can not be null");
            }
            if (category.Type.Equals(null))
            {
                throw new ArgumentException("type can not be null");
            }
        }


    }
}
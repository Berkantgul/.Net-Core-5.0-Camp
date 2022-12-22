using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.entity.Concrete;
using blog.data.Concrete;
using blog.data.Abstract;

namespace blog.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void AddCategory(Category category)
        {
            _categoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }



        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
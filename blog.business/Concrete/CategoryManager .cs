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

        public void Add(Category entity)
        {
            _categoryRepository.Insert(entity);
        }
        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }
        public List<Category> GetAllList()
        {
            return _categoryRepository.GetAll();
        }
        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }
        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
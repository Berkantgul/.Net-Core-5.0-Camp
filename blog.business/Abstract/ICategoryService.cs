using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        
        // void Update(Category category);
        // List<Category> GetAllCategory();
        // Category GetById(int id);
        // void DeleteCategory(Category category);
        // void AddCategory(Category category);
    }
}
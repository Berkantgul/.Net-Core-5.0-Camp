using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        // void UpdateBlog(Blog blog);
        // void DeleteBlog(Blog blog);
        // List<Blog> GetAllBlog();
        // Blog GetByIdBlog(int id);
        // void AddBlog(Blog blog);
        List<Blog> GetBlogWithCategory();
        // List<Blog> GetAll(int id);
        List<Blog> GetAuthorPopularPost(int id);
        List<Blog> GetAuthorBlogList(int id);
        int WidgetBlogCount();
        string WidgetLastBlog();
    }
}
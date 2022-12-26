using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.data.Abstract;
using blog.entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace blog.data.Concrete
{
    public class EfCoreBlogRepository : EfCoreGenericRepository<Blog>, IBlogRepository
    {
        public List<Blog> GetBlogWithCategory()
        {
            using (var context = new BlogContext())
            {
                var blogs = context.Blogs.Include(x => x.Category).ToList();
                return blogs;
            }
        }
    }
}
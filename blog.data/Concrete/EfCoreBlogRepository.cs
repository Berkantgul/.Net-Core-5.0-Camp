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
        public List<Blog> GetAuthorPopularPost(int id)
        {
            using (BlogContext context = new BlogContext())
            {
                var blogs = context.Blogs.Where(i => i.AuthorId == id).OrderByDescending(i => i.BlogCreateDate).Take(2).ToList();
                return blogs;
            }
        }

        public List<Blog> GetBlogWithCategory()
        {
            using (var context = new BlogContext())
            {
                var blogs = context.Blogs.Include(x => x.Category).ToList();
                return blogs;
            }
        }
        public List<Blog> GetAuthorBlogListWithAuthorImg()
        {
            using (var context = new BlogContext())
            {
                var blogs = context.Blogs.Where(i => i.AuthorId == 1).Include(x => x.Author).ToList();
                return blogs;
            }
        }

        public int BlogCount()
        {
            using (var context = new BlogContext())
            {
                var count = context.Blogs.Count();
                return count;
            }
        }

        public string LastBlog()
        {
            using (var context = new BlogContext())
            {
                var blog = context.Blogs.Select(i => i.BlogTitle).Take(1).FirstOrDefault();
                return blog;
            }
        }
    }
}
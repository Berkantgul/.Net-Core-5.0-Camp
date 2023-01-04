using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.data.Abstract
{
    public interface IBlogRepository : IRepository<Blog>
    {
        List<Blog> GetBlogWithCategory();
        List<Blog> GetAuthorPopularPost(int id);
        List<Blog> GetAuthorBlogListWithAuthorImg();
    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll(int id)
        {
            return _blogRepository.GetAll(i => i.BlogId == id);
        }

        public List<Blog> GetAllBlog()
        {
            return _blogRepository.GetAll();
        }

        public List<Blog> GetAuthorPopularPost(int id)
        {
            return _blogRepository.GetAuthorPopularPost(id);
        }

        public List<Blog> GetBlogWithCategory()
        {
            return _blogRepository.GetBlogWithCategory();
        }

        public Blog GetByIdBlog(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
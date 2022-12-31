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
        public List<Blog> GetAll(int id)
        {
            return _blogRepository.GetAll(i => i.BlogId == id);
        }

        public List<Blog> GetAuthorPopularPost(int id)
        {
            return _blogRepository.GetAuthorPopularPost(id);
        }

        public List<Blog> GetBlogWithCategory()
        {
            return _blogRepository.GetBlogWithCategory();
        }

        public List<Blog> GetLastBlog3Posts()
        {
            return _blogRepository.GetAll().TakeLast(3).ToList();
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllList()
        {
            return _blogRepository.GetAll();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
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

        public Blog TGetById(int id)
        {
            return _blogRepository.GetById(id);
        }

        public void TDelete(Blog entity)
        {
            _blogRepository.Delete(entity);
        }

        public void Add(Blog entity)
        {
            _blogRepository.Insert(entity);
        }

        public List<Blog> GetAuthorBlogList(int id)
        {
            return _blogRepository.GetAll(i => i.AuthorId == 1);
        }
        public List<Blog> GetAuthorBlogListWithAuthorImg()
        {
            return _blogRepository.GetAuthorBlogListWithAuthorImg();
        }

        public int WidgetBlogCount()
        {
            return _blogRepository.BlogCount();
        }

        public string WidgetLastBlog()
        {
            return _blogRepository.LastBlog();
        }

        public Task<List<Blog>> ApiGetAll()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
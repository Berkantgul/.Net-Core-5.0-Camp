using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Add(Comment entity)
        {
            _commentRepository.Insert(entity);
        }

        public void TDelete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllList()
        {
            throw new NotImplementedException();
        }

        

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentByBlog(int id)
        {
            return _commentRepository.GetAll(i => i.BlogId == id);
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }

        public int WidgetCommentCount()
        {
            return _commentRepository.CommentCount();
        }

        public Task<List<Comment>> ApiGetAll()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        // void AddComment(Comment comment);
        // List<Comment> GetAll();
        // Comment GetById(int id);
        // void UpdateComment(Comment comment);
        // void Delete(Comment comment);
        List<Comment> GetCommentByBlog(int id);
        int WidgetCommentCount();
        
    }
}
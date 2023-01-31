using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.data.Concrete
{
    public class EfCoreCommentRepository : EfCoreGenericRepository<Comment>, ICommentRepository
    {
        public int CommentCount()
        {
            using (var context = new BlogContext())
            {
                var count = context.Comments.Count();
                return count;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.data.Abstract;
using blog.entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace blog.data.Concrete
{
    public class EfCoreMessageRepository : EfCoreGenericRepository<Message>, IMessageRepository
    {
        public List<Message> AuthorMessageInbox(int id)
        {
            using (var context = new BlogContext())
            {
                var blogs = context.Messages.Include(i=>i.SenderUser).ToList();
                return blogs;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.data.Abstract
{
    public interface IMessageRepository : IRepository<Message>
    {
        List<Message> AuthorMessageInbox(int id);
    }
}
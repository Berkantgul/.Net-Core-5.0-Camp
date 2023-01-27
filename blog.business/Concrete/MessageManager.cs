using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        public MessageManager(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public void Add(Message entity)
        {
            throw new NotImplementedException();
        }

        public List<Message> AuthorInbox(int id)
        {
            return _messageRepository.AuthorMessageInbox(id);
        }

        public List<Message> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message entity)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
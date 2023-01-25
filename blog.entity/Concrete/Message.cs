using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class Message
    {
        public int MessageId { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public Author SenderUser { get; set; }
        public Author ReceiverUser { get; set; }
    }
}
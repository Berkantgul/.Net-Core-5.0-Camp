using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string NotificationTypeSymbol { get; set; }
        public string NotificationDetail { get; set; }
        public string NotificationTypeColor { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool NotificationStatus { get; set; }
    }
}
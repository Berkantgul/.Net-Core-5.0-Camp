using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.data.Abstract;
using blog.entity.Concrete;

namespace blog.business.Concrete
{
    public class NotificationManager : INotificationService
    {
        private  INotificationRepository _notificationRepository;
        public NotificationManager(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        public void Add(Notification entity)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetAllList()
        {
            var values = _notificationRepository.GetAll(i=>i.NotificationStatus==true).TakeLast(3).ToList();
            return values;
        }

        public void TDelete(Notification entity)
        {
            throw new NotImplementedException();
        }

        public Notification TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}
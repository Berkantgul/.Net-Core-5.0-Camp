using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using Microsoft.AspNetCore.Mvc;
using blog.data.Concrete;

namespace blog.webui.ViewComponents
{
    public class GetNotificationList : ViewComponent
    {
        NotificationManager _notificationManager = new NotificationManager(new EfCoreNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = _notificationManager.GetAllList();
            return View(values);
        }
    }
}
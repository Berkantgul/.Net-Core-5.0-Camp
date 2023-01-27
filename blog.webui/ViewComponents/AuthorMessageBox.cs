using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.ViewComponents
{
    public class AuthorMessageBox : ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfCoreMessageRepository());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            var values = _messageManager.AuthorInbox(id).TakeLast(3).ToList();
            return View(values);

        }
    }
}
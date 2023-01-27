using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class MessageController : Controller
    {
        MessageManager _messageManager = new MessageManager(new EfCoreMessageRepository());
        public IActionResult MessageInbox()
        {
            int id = 2;
            var values = _messageManager.AuthorInbox(id);
            return View(values);
        }

    }
}
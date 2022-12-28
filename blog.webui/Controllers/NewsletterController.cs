using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager _newsletterManager = new NewsletterManager(new EfCoreNewsletterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(Newsletter news, int id)
        {
            news.MailStatus = true;
            _newsletterManager.SubscribeMail(news);
            return Redirect("/Blog/BlogDetail/" + id);
        }
    }
}
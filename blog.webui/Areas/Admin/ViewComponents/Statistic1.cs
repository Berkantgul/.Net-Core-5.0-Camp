using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blog.webui.Areas.Admin.ViewComponents
{
    public class Statistic1 : ViewComponent
    {
        CommentManager _commentManager = new CommentManager(new EfCoreCommentRepository());
        BlogManager _blogManager = new BlogManager(new EfCoreBlogRepository());
        ContactManager _contactManager = new ContactManager(new EfCoreContactRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = _blogManager.WidgetBlogCount();
            ViewBag.CommentCount = _commentManager.WidgetCommentCount();
            ViewBag.ContactCount = _contactManager.WidgetContactCount();
            string api = "1dee61063c4375d506a93bc877b0b5b9";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Istanbul&units=metric&appid=" + api + "&mode=xml";
            XDocument document = XDocument.Load(connection);
            ViewBag.Weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.City = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            return View();
        }
    }
}

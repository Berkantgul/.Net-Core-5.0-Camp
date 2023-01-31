using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.ViewComponents
{
    public class Statistic2 : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfCoreBlogRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.LastBlog = _blogManager.WidgetLastBlog();
            return View();
        }
    }
}

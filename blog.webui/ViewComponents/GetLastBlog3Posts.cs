using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.ViewComponents
{
    public class GetLastBlog3Posts : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfCoreBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetLastBlog3Posts();
            return View(values);
        }
    }
}
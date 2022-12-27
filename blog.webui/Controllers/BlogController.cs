using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.business.Concrete;
using blog.data.Abstract;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfCoreBlogRepository());
        public IActionResult Index()
        {
            var blogs = _blogManager.GetBlogWithCategory();
            return View(blogs);
        }
        public IActionResult BlogDetail(int id)
        {
            ViewBag.id = id;
            var blogs = _blogManager.GetAll(id);
            return View(blogs);
        }
    }
}
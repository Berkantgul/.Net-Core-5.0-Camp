using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCoreCategoryRepository());
        public IActionResult Index()
        {
            var values = categoryManager.GetAllList();
            return View(values);
        }
    }
}
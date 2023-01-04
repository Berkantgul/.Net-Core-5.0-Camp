using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.ViewComponents
{
    public class AuthorDashboardCategoryList : ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCoreCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var categories = _categoryManager.GetAllList();
            return View(categories);
        }
    }
}
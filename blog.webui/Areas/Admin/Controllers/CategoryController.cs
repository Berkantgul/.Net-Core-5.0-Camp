using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace blog.webui.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCoreCategoryRepository());
        public IActionResult CategoryList(int page = 1)
        {
            var values = _categoryManager.GetAllList().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(AddCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    CategoryName = model.CategoryName,
                    CategoryDescription = model.CategoryDescription,
                    CategoryStatus = true
                };
                _categoryManager.Add(category);
                return RedirectToAction("CategoryList");
            }
            return View(model);
        }
        public IActionResult DeleteCategory(int id)
        {
            var entity = _categoryManager.TGetById(id);
            if (entity != null)
            {
                _categoryManager.TDelete(entity);
                return RedirectToAction("CategoryList");
            }
            return View();
        }
    }
}
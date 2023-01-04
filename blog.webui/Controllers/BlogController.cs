using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Abstract;
using blog.business.Concrete;
using blog.data.Abstract;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            NewsletterModel news = new NewsletterModel();
            ViewBag.neewsl = news;
            var blogs = _blogManager.GetAll(id);
            return View(blogs);
        }
        public IActionResult AuthorBlogList()
        {
            var blogs = _blogManager.GetAuthorBlogListWithAuthorImg();
            return View(blogs);
        }
        [HttpGet]
        public IActionResult AuthorAddBlog()
        {

            ViewBag.cv = GetSelectCategoryList();
            return View();
        }
        [HttpPost]
        public IActionResult AuthorAddBlog(AuthorBlogModel model)
        {
            if (ModelState.IsValid)
            {
                var blog = new Blog()
                {
                    BlogCreateDate = (DateTime)DateTime.Now,
                    BlogStatus = true,
                    BlogContent = model.BlogContent,
                    BlogImage = model.BlogImage,
                    BlogTitle = model.BlogTitle,
                    AuthorId = 1,
                    CategoryId = model.CategoryId
                };
                _blogManager.Add(blog);
                return RedirectToAction("AuthorBlogList");
            }
            
            ViewBag.cv = GetSelectCategoryList();
            return View(model);
        }
        public IActionResult AuthorDeleteBlog(int id)
        {
            var entity = _blogManager.TGetById(id);
            _blogManager.TDelete(entity);

            return RedirectToAction("AuthorBlogList");
        }

        [HttpGet]
        public IActionResult AuthorEditBlog(int? id)
        {
            var entity = _blogManager.TGetById((int)id);
            var model = new AuthorBlogModel()
            {
                BlogId = entity.BlogId,
                BlogContent = entity.BlogContent,
                BlogTitle = entity.BlogTitle,
                BlogImage = entity.BlogImage,
                Categorys = entity.Category
            };
            ViewBag.cm = GetSelectCategoryList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AuthorEditBlog(AuthorBlogModel model)
        {
            return View();
        }


        List<SelectListItem> GetSelectCategoryList()
        {
            CategoryManager cm = new CategoryManager(new EfCoreCategoryRepository());
            List<SelectListItem> categoryValues = (from x in cm.GetAllList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            return categoryValues;
        }
    }

}
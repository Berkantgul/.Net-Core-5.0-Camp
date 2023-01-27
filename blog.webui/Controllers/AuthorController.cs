using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class AuthorController : Controller
    {
        AuthorManager _authorManager = new AuthorManager(new EfCoreAuthorRepository());
        BlogManager _blogManager = new BlogManager(new EfCoreBlogRepository());
        CategoryManager _categoryManager = new CategoryManager(new EfCoreCategoryRepository());
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            ViewBag.BlogCOunt = BlogCount();
            ViewBag.AuthorBlogCount = AuthorBlogCount();
            ViewBag.CategoryCount = CategoryCount();
            return View();
        }
        [HttpGet]
        public IActionResult AuthorUpdate()
        {
            var entity = _authorManager.TGetById(2);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new AuthorUpdateModel()
            {
                AuthorId = entity.AuthorId,
                AutorName = entity.AutorName,
                Mail = entity.Mail,
                Password = entity.Password,
                AuthorAbout = entity.AuthorAbout
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AuthorUpdate(AuthorUpdateModel model)
        {
            var entity = _authorManager.TGetById(model.AuthorId);
            if (ModelState.IsValid)
            {
                if (model.AuthorImage != null)
                {
                    var extension = Path.GetExtension(model.AuthorImage.FileName);
                    var newimagename = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                    var stream = new FileStream(location, FileMode.Create);
                    model.AuthorImage.CopyTo(stream);
                    entity.AuthorImage = newimagename;
                }
                entity.Mail = model.Mail;
                entity.AutorName = model.AutorName;
                entity.Password = model.Password;
                entity.AuthorStatus = true;
                entity.AuthorAbout = model.AuthorAbout;

                _authorManager.Update(entity);
                return Redirect("/Author/Dashboard");
            }
            return View(model);
        }
        int BlogCount()
        {
            return _blogManager.GetAllList().Count();
        }
        int AuthorBlogCount()
        {
            return _blogManager.GetAuthorBlogList(1).Count();
        }
        int CategoryCount()
        {
            return _categoryManager.GetAllList().Count;
        }
    }

}
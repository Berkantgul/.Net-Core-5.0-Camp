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
    public class RegisterController : Controller
    {
        AuthorManager _authorManager = new AuthorManager(new EfCoreAuthorRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Author()
                {
                    AutorName = model.AutorName,
                    Password = model.Password,
                    Mail = model.Mail,
                    AuthorStatus = true,
                    AuthorAbout = "Test"
                };
                _authorManager.CreateAuthor(entity);
                return Redirect("/Blog/Index");
            }
            return View(model);
        }
    }
}
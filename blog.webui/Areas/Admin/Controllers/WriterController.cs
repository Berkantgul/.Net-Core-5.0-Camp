using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Areas.Admin.Models;
using blog.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class WriterController : Controller
    {
        AuthorManager _authorManager = new AuthorManager(new EfCoreAuthorRepository());
        public IActionResult Index()
        {

            return View();
        }
        [AllowAnonymous]
        public IActionResult AjaxAuthorList()
        {

            var jsonlist = JsonConvert.SerializeObject(GetAuthorModel());
            return Json(jsonlist);
        }
        public IActionResult AuthorGetById(int writerid)
        {
            var authors = GetAuthorModel().FirstOrDefault(i => i.AuthorId == writerid);
            var jsonList = JsonConvert.SerializeObject(authors);
            return Json(jsonList);
        }
        public IActionResult AddAuthor(AuthorModel model)
        {

            Author entity = new Author();
            if (model != null)
            {
                entity.AutorName = model.AuthorName;
                entity.AuthorStatus = true;
                entity.Mail = model.Mail;
                entity.AuthorImage = "4628f1cd-84ad-4b6c-81c3-65f2704519de.jpg";
                _authorManager.Add(entity);

            }

            return Json(entity);
        }
        public IActionResult DeleteAuthor(int id)
        {

            var author = _authorManager.TGetById(id);
            var entity = GetAuthorModel().FirstOrDefault(i => i.AuthorId == author.AuthorId);
            _authorManager.TDelete(author);
            return Json(JsonConvert.SerializeObject(entity));

        }
        public List<AuthorModel> GetAuthorModel()
        {
            List<AuthorModel> authorModels = new List<AuthorModel>();
            foreach (var item in _authorManager.GetAllList())
            {
                authorModels.Add(new AuthorModel
                {
                    AuthorId = item.AuthorId,
                    AuthorName = item.AutorName
                });
            }
            return authorModels;
        }



    }
}

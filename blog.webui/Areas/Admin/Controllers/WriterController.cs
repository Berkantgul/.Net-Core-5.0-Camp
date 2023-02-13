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
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
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

            entity.Concrete.Author entity = new entity.Concrete.Author();
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
        [AllowAnonymous]
        public async Task<IActionResult> ApiAuthorList()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:5001/api/author");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ApiAuthorModel>>(jsonString);
            return View(values);
        }

        [HttpGet]
        public IActionResult ApiAddAuthor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ApiAddAuthor(ApiAuthorModel model)
        {
            
                var httpClient = new HttpClient();
                var jsonAuthor = JsonConvert.SerializeObject(model);
                var content = new StringContent(jsonAuthor, Encoding.UTF8, "application/json");
                var responseMessage = await httpClient.PostAsync("https://localhost:5001/api/author", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("ApiAuthorList");
                }
            

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ApiUpdateAuthor(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:5001/api/author/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonAuthor = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ApiAuthorModel>(jsonAuthor);

                return View(values);
            }
            Console.WriteLine(responseMessage.RequestMessage.ToString());
            return RedirectToAction("ApiAuthorList");

        }
        [HttpPost]
        public async Task<IActionResult> ApiUpdateAuthor(ApiAuthorModel model)
        {
            var httpClient = new HttpClient();
            var jsonAuthor = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonAuthor, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PutAsync("https://localhost:5001/api/author/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ApiAuthorList");
            }
            Console.WriteLine(responseMessage.StatusCode);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ApiDeleteAuthor(int id)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync("https://localhost:5001/api/author/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ApiAuthorList");
            }
            return View();
        }


    }
}








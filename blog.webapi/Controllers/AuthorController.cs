using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using blog.webui.Areas.Admin.Models;
using blog.webui.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace blog.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        AuthorManager _authorManager = new AuthorManager(new EfCoreAuthorRepository());
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var authors = new List<ApiAuthorModel>();
            foreach (var item in await _authorManager.ApiGetAll())
            {
                authors.Add(new ApiAuthorModel()
                {
                    AuthorId = item.AuthorId,
                    AuthorName = item.AutorName,
                    Mail = item.Mail,
                    Password = item.Password
                });
            }

            return Ok(authors);
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthor(webui.Areas.Admin.Models.ApiAuthorModel model)
        {

            var entity = new entity.Concrete.Author()
            {
                AutorName = model.AuthorName,
                Password = model.Password,
                Mail = model.Mail,
                AuthorStatus = true,
            };
            await _authorManager.AddAsync(entity);

            return Ok();


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var author = _authorManager.TGetById(id);
            if (author == null)
            {
                return NotFound();
            }
            await _authorManager.DeleteAsync(author);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AuthorGetById(int id)
        {

            var author = await _authorManager.GetByIdAsync(id);
            if (author == null)
            {
                return BadRequest();
            }
            else
            {
                var apiauthor = new ApiAuthorModel()
                {
                    AuthorId = author.AuthorId,
                    AuthorName = author.AutorName,
                    Mail = author.Mail,
                    Password = author.Password
                };

                return Ok(apiauthor);
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthor(int id, ApiAuthorModel model)
        {
            var author = await _authorManager.GetByIdAsync(id);
            if (author == null)
            {
                return BadRequest();
            }
            else
            {
                author.AutorName = model.AuthorName;
                author.Mail = model.Mail;
                Console.WriteLine(author.Mail);
                await _authorManager.UpdateAuthorAsync(author);
                return Ok();
            }
        }
    }
}
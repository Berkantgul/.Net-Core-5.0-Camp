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
            return Ok(await _authorManager.ApiGetAll());
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthor(ApiAuthorModel model)
        {
            
                var entity = new Author()
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
    }
}
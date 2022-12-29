using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using blog.data.Concrete;
using blog.webui.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            BlogContext cm = new BlogContext();
            if (ModelState.IsValid)
            {
                var value = cm.Authors.FirstOrDefault(i => i.Password == model.Password && i.Mail == model.Mail);
                if (value != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,model.Mail)
                    };

                    var useridentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                }
            }

            ModelState.AddModelError("", "Parola veya Email yanlış");
            return View(model);

        }
    }
}
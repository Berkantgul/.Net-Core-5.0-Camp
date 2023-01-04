using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new EfCoreAboutRepository());
        public IActionResult Index()
        {
            var abouts = _aboutManager.GetAll();
            return View(abouts);
        }
        public PartialViewResult StayConnect()
        {
            return PartialView();
        }
    }
}
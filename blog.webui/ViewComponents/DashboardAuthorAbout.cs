using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.ViewComponents
{
    public class DashboardAuthorAbout : ViewComponent
    {
        AuthorManager _aboutManager = new AuthorManager(new EfCoreAuthorRepository());
        public IViewComponentResult Invoke()
        {
            var author = _aboutManager.GetAllAuthor(1);
            return View(author);
        }
    }
}
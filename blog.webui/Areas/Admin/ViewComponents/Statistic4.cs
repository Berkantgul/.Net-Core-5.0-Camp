using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.ViewComponents
{
    public class Statistic4 : ViewComponent
    {
        AdminManager _adminManager = new AdminManager(new EfCoreAdminRepository());
        public IViewComponentResult Invoke()
        {

            return View(_adminManager.GetAllList());
        }
    }
}

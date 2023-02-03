using blog.entity.Concrete;
using blog.webui.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        //void AddtoChartModel()
        //{
        //    List<Category> cm = new List<Category>();
        //    ChartModel chartModel;
        //    foreach (var item in collection)
        //    {

        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using blog.webui.Areas.Admin.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfCoreBlogRepository());
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Adı";
                worksheet.Cell(1, 3).Value = "Blog Tarih";

                worksheet.Range("A1:B1").Style.Font.FontColor = XLColor.Red;

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.BlogId;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    worksheet.Cell(BlogRowCount, 3).Value = item.BlogDate;

                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }

            }
        }
        public IActionResult StatixExcelReport()
        {
            return View();
        }
        public List<StaticExcelBlogModel> GetBlogList()
        {
            var blogs = _blogManager.GetAllList();
            List<StaticExcelBlogModel> model = new List<StaticExcelBlogModel>();
            StaticExcelBlogModel blog;
            foreach (var item in blogs)
            {
                blog = new StaticExcelBlogModel { BlogId = item.BlogId, BlogName = item.BlogTitle, BlogDate = item.BlogCreateDate };
                model.Add(blog);
            }
            return model;
        }

    }
}
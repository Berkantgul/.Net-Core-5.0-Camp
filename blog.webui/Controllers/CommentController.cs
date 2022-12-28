using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using blog.entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _commentManager = new CommentManager(new EfCoreCommentRepository());
        [HttpGet]
        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult LeaveComment(Comment cm, int id)
        {
            cm.CommentDate = (DateTime)DateTime.Now;
            cm.CommentStatus = true;
            cm.BlogId = 9;
            _commentManager.AddComment(cm);
            return View();
        }
    }
}
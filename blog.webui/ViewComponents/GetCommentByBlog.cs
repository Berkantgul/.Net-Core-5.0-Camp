using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.business.Concrete;
using blog.data.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace blog.webui.ViewComponents
{
    public class GetCommentByBlog : ViewComponent
    {
        CommentManager _commentManager = new CommentManager(new EfCoreCommentRepository());
        public IViewComponentResult Invoke()
        {
            var comments = _commentManager.GetCommentByBlog(9);
            return View(comments);
        }
    }
}
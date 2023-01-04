using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;

namespace blog.webui.Models
{
    public class AuthorBlogModel
    {
        public int BlogId { get; set; }
        [Required(ErrorMessage = "İçeriğinizi tekrar gözden geçiriniz..")]
        public string BlogContent { get; set; }
        [Required(ErrorMessage = "Başlık alanını tekrar gözden geçiriniz..")]
        public string BlogTitle { get; set; }
        [Required(ErrorMessage = "Resim alanını tekrar gözden geçiriniz..")]
        public string BlogImage { get; set; }
        [Required(ErrorMessage ="Category Gerekli alan")]
        public int CategoryId { get; set; }
        public Category Categorys { get; set; }
    }
}
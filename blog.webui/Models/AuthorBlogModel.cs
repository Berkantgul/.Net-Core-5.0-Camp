using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class AuthorBlogModel
    {
        [Required(ErrorMessage = "İçeriğinizi tekrar gözden geçiriniz..")]
        public string BlogContent { get; set; }
        [Required(ErrorMessage = "Başlık alanını tekrar gözden geçiriniz..")]
        public string BlogTitle { get; set; }
        [Required(ErrorMessage = "Resim alanını tekrar gözden geçiriniz..")]
        public string BlogImage { get; set; }
        [Required(ErrorMessage ="Category Gerekli alan")]
        public int CategoryId { get; set; }
    }
}
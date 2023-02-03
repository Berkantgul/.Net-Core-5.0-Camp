using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage ="Hata")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Hata")]
        public string Mail { get; set; }
    }
}

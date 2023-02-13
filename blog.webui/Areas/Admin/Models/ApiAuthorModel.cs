using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.Models
{
    public class ApiAuthorModel
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez!")]
        public string AuthorName { get; set; }
        [Required(ErrorMessage = "Mail alanı gereklidir!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

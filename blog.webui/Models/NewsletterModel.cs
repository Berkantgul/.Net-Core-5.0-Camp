using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class NewsletterModel
    {
        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
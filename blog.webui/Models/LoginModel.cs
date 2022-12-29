using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email alanı zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Email alanı zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name alanı boş geçilemez!")]
        [StringLength(maximumLength: 20, MinimumLength = 1, ErrorMessage = "Name alanı 1-20 karakter arası olmalıdır!")]
        public string AutorName { get; set; }
        [Required(ErrorMessage = "Name alanı boş geçilemez!")]
        [StringLength(maximumLength: 30, MinimumLength = 7, ErrorMessage = "Name alanı 7-30 karakter arası olmalıdır!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilemez!")]
        // [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*+\\/|!\"£$%^&*()#[@~'?><,.=_-]).{6,}$", ErrorMessage = "Şifre alanı alphanumeric değerler içermelidir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor!")]
        [DataType(DataType.Password)]
        public string CheckedPassword { get; set; }

    }
}
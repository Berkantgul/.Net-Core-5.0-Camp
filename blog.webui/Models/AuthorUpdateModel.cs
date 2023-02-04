using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace blog.webui.Models
{
    public class AuthorUpdateModel
    {
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez!")]
        [StringLength(maximumLength: 30, MinimumLength = 2,ErrorMessage ="Karakter uzunluğu 2-30 arası olmalıdır!")]
        public string AutorName { get; set; }
        [Required(ErrorMessage = "Görsel alanı gereklidir!")]
        public IFormFile AuthorImage { get; set; }
        [Required(ErrorMessage ="Mail alanı gereklidir!")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage ="Şifre alanı gereklidir!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifre alanı gereklidir!")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler birbirine uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Hakkında kısmı boş geçilemez!")]
        public string AuthorAbout { get; set; }
    }
}
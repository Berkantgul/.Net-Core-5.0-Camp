using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Ad alanı zorunludur")]
        [StringLength(maximumLength: 25, MinimumLength = 1, ErrorMessage = "1-25 arası olmalıdır")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email alanı zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Konu alanı zorunludur")]
        [StringLength(maximumLength: 50, MinimumLength = 1, ErrorMessage = "1-50 arası olmalıdır")]
        public string ContactSubject { get; set; }
        [Required(ErrorMessage = "Mesaj alanı zorunludur")]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "1-100 arası olmalıdır")]
        public string ContactMessage { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Areas.Admin.Models
{
    public class AddCategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori adı boş geçilemez!")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Açıklama kısmı boş geçilemez!")]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
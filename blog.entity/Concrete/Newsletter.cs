using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class Newsletter
    {
        [Key]
        public int MailId { get; set; }
        public string Mail { get; set; }
        public bool MailStatus { get; set; }
    }
}
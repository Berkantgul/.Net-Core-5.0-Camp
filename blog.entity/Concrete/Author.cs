using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AutorName { get; set; }
        public string AuthorImage { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string AuthorAbout { get; set; }
        public bool AuthorStatus { get; set; }
    }
}
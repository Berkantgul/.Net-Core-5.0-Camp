using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogContent { get; set; }
        public string BlogTitle { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
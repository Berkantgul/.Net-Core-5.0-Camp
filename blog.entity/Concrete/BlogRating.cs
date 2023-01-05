using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class BlogRating
    {
        public int BlogRatingId { get; set; }
        public int BlogId { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRatingCount { get; set; }
    }
}
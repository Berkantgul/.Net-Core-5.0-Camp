﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.entity.Concrete
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
    }
}

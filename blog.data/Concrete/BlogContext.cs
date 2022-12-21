using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace blog.data.Concrete
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-UROTH5AA;database=CoreBlogDb;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
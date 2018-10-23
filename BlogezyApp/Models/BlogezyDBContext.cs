using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogezyApp.Models
{
    public class BlogezyDBContext:DbContext
    {
        public BlogezyDBContext(DbContextOptions<BlogezyDBContext> options) :base(options) { }


        public DbSet<Post> Posts { get; set; }


        public DbSet<Comment> Comments { get; set; } 
    }
}

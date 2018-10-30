using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogezyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogezyApp.Controllers
{
    public class HomeController : Controller
    {  
        private BlogezyDBContext db { get; }
         

        //public HomeController(DbContextOptions<BlogezyDBContext> options)
        //{
        //    db = new BlogezyDBContext(options);
        //}

        public HomeController(BlogezyDBContext blogezyDBContext)
        {
            db = blogezyDBContext;
            
        }

        public async Task<IActionResult> Index()
        {  
            List<Post> posts = await db.Posts.ToListAsync();
            List<Comment> comments = await db.Comments.ToListAsync();
            foreach (Post post in posts)
            {
                post.Comments = comments.Where(c => c.PostId == post.Id).ToList();
            }
            return View(posts);
        }
    }
}
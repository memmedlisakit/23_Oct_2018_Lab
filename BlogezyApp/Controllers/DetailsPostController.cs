using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogezyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogezyApp.Controllers
{
    public class DetailsPostController : Controller
    {
        private BlogezyDBContext db;

        public DetailsPostController(DbContextOptions<BlogezyDBContext> options)
        {
          db = new BlogezyDBContext(options);
        }
       

        public IActionResult Index(int? id)
        {
            Post post = db.Posts.Find(id);
            post.Comments = db.Comments.Where(c => c.PostId == id).ToList();
            return View(post);
        }
    }
}
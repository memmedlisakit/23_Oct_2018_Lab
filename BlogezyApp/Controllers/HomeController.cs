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

        public IActionResult Index()
        {  
            List<Post> posts = db.Posts.ToList();

            return Content(posts[0].Details);
            return View();
        }
    }
}
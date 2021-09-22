using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCaliforniaApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return new ContentResult { Content = "BlogController!" };
            return View();
        }

        [Route("blog/{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            //return new ContentResult { Content = string.Format("Year: {0}; Month: {1}; Key:{2}", year, month, key) };

            ViewBag.Title = "My blog post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Jess Chadwick";
            ViewBag.Body = "This is a a great blog post, dont ya think?!";
            return View();
        }
    }
}

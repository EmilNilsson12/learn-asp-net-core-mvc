﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExploreCaliforniaApp.Models;

namespace ExploreCaliforniaApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            //return new ContentResult { Content = "BlogController!" };
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();
            return View(posts);
        }

        [Route("blog/{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            //return new ContentResult { Content = string.Format("Year: {0}; Month: {1}; Key:{2}", year, month, key) };
            //ViewBag.Title = "My blog post";
            //ViewBag.Posted = DateTime.Now;
            //ViewBag.Author = "Jess Chadwick";
            //ViewBag.Body = "This is a a great blog post, dont ya think?!";

            var post = new Post {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Jess Chadwick",
                Body = "This is a great blog post, imho..."
            };

            return View(post);
        }

        [HttpGet, Route("blog/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("blog/create")]
        public IActionResult Create(Post post)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            // Override Author and Posted with values that the User cannot change
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;


            _db.Posts.Add(post);
            _db.SaveChanges();



            return View();
        }
    }
}

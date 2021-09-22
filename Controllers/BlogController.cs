using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCaliforniaApp.Controllers
{
    public class BlogController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new ContentResult { Content = "BlogController!" };
        }

        public IActionResult Post(int id = -1)
        {
            // Using C# optional parameter syntax
            // If id is not valid int, it will be changed to -1
            return new ContentResult { Content = id.ToString() };
        }
    }
}

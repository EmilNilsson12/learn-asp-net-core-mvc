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

        public IActionResult Post(bool id)
        {
            // Will convert id to bool
            // All values except true will return the default bool value: false
            return new ContentResult { Content = id.ToString() };
        }
    }
}

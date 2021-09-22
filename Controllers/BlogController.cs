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

        public IActionResult Post(int id)
        {
            // will convert id param to default int value: 0
            // unless id is valid int
            // then that int will be displayed
            return new ContentResult { Content = id.ToString() };
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExploreCaliforniaApp.Models
{
    public class Post
    {
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title { get; set; }

        public string Author { get; set; }
        [Required]
        [MinLength(100, ErrorMessage = "Blog posts must be at least 100 characters long")]
        public string Body { get; set; }
        public DateTime Posted { get; set; }
    }
}

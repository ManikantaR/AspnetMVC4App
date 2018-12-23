﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspnetMVC4App.Models
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CountOfReviews { get; set; }
    }
}
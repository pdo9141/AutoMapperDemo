﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books.Web.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_4.Models
{
    public class Book
        {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string  Author { get; set; }

        public string Category { get; set; }
        // цена
        public int Price { get; set; }
    }
}
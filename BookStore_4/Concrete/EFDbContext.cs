using BookStore_4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore_4.Concrete
{
    
       public class EFDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}

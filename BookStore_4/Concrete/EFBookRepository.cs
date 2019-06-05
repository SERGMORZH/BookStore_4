using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore_4.Abstract;
using BookStore_4.Models;

namespace BookStore_4.Concrete
{
    public class EFBookRepository : IBookRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Book> Books
        {
            get { return context.Books;}
           
        }

        
    }
}

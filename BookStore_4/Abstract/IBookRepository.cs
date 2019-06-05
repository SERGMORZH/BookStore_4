using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore_4.Models;

namespace BookStore_4.Abstract
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
    }

}


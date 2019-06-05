using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore_4.Models;

namespace BookStore_4.Abstract
{
    public interface IRepository
    {
        void Save(Book b);
        IEnumerable<Book> List();
        Book Get(int id);
    }

    public class BookRepository : IDisposable, IRepository
    {
        private BookContext db = new BookContext();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> List()
        {
            throw new NotImplementedException();
        }

        public void Save(Book b)
        {
            throw new NotImplementedException();
        }
        // методы

    }
}
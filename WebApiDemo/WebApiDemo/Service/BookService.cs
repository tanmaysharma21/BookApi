using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Database;
using WebApiDemo.Model;

namespace WebApiDemo.Service
{
    public class BookService
    {
        public BookData bookData = new BookData();

        public List<Book> Get()
        {
            return bookData.GetBooks();
        }

        public Book Get(int id)
        {
            if (id <= 0)
                throw new Exception();
            return bookData.GetBookById(id);
        }

        public void Post(Book book)
        {
            bookData.Add(book);
        }

        public void Put(int id, Book book)
        {
            if (id < 0)
                throw new Exception();
            bookData.Update(id, book);
        }

        public void Delete(int id)
        {
            if (id < 0)
                throw new Exception();
            bookData.DeleteBook(id);
        }

    }
}

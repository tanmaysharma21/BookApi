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

        public bool Post(Book book)
        {
            if (!ValidateBook(book))
                throw new Exception();
            try
            {
                bookData.Add(book);
                return true;
            }
            catch
            {
                throw new Exception();
            }
        }

        public bool ValidateBook(Book book)
        {
            if (book.Id <= 0)
                return false;
            if (book.Name == null || book.Author == null || book.Category == null)
                return false;
            if (book.Price <= 0)
                return false;
            return true;
        }

        public bool Put(int id, Book book)
        {
            if (!ValidateBook(book))
                throw new Exception();
            if (id < 0)
                throw new Exception();
            bookData.Update(id, book);
            return true;
        }

        public bool Delete(int id)
        {
            if (id <= 0)
                throw new Exception();
            bookData.DeleteBook(id);
            return true;
        }

    }
}

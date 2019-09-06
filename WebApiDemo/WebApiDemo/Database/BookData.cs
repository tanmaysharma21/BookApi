using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Model;

namespace WebApiDemo.Database
{
    public class BookData
    {
        public static List<Book> bookList = new List<Book>()
        {
            new Book(){ Name = "C# Basics", Author="PK", Category="CSE", Id = 101, Price=500},
            new Book(){ Name = "Microprocessor", Author="Sinha", Category="Electronics", Id = 73, Price=792}
        };

        public List<Book> GetBooks()
        {
            return bookList;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in bookList)
            {
                if (book.Id == id)
                    return book;
            }
            throw new Exception();
        }

        public void Add(Book book)
        {
            bookList.Add(book);
        }

        public void Update(int id, Book book)
        {
            int x = 0;
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Id == id)
                {
                    bookList[i] = book;
                    x=1;
                    break;
                }
            }
            if (x == 0)
                throw new Exception();
        }

        public void DeleteBook(int id)
        {
            var book = bookList.Find(b => b.Id == id);
            bookList.Remove(book);
        }

    }
}

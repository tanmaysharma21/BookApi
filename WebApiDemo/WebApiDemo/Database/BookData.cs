using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.ApiReturnModel;
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

        public void GetBooks(ApiModel apiModel)
        {
            apiModel.AddBookList(bookList);
        }

        public void GetBookById(int id, ApiModel apiModel)
        {
            bool bookIsPresent = false;
            foreach (Book book in bookList)
            {
                if (book.Id == id)
                {
                    apiModel.AddBook(book);
                    bookIsPresent = true;
                    break;
                }
            }

            if (!bookIsPresent)
                apiModel.AddError("BookNotPresent");            
        }

        public void Add(Book book)
        {
            bookList.Add(book);
        }

        public void Update(int id, Book book, ApiModel apiModel)
        {
            int x = 0;
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Id == id)
                {
                    bookList[i] = book;
                    x = 1;
                    break;
                }
            }
            if (x == 0)
                apiModel.AddError("BookNotPresent");
            //bookList[bookList.IndexOf(bookList.Where().FirstOrDefault())] = book;

        }

        public void DeleteBook(int id, ApiModel apiModel)
        {
            var book = bookList.Find(b => b.Id == id);
            if (book==null)
                apiModel.AddError("BookNotPresent");
            else
                bookList.Remove(book);
        }

    }
}

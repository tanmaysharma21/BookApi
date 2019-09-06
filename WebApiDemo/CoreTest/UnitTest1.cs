using System;
using System.Collections.Generic;
using WebApiDemo.Model;
using WebApiDemo.Service;
using Xunit;

namespace CoreTest
{
    public class UnitTest1
    {
        BookService bookService;
        public UnitTest1()
        {
            bookService = new BookService();
        }

        [Fact]
        public void Get_CountOfList_2()
        {
            
            List<Book> bookList = bookService.Get();
            Assert.Equal(2, bookList.Count);
        }

        [Fact]
        public void Get_InvalidId_ThrowsException()
        {
            Assert.Throws<Exception>(() => bookService.Get(33));
        }

        [Fact]
        public void Post_CountOfList_3()
        {
            bookService.Post(new Book() { Name = "Flights", Author = "APJ", Category = "Fiction", Id = 231, Price = 732 } );
            List<Book> bookList = bookService.Get();
            Assert.Equal(3, bookList.Count);
        }

        [Fact]
        public void Put_InvalidBookObject_ThrowsException()
        {
            Book book = new Book() { Name = "Tanmay" };
            Assert.Throws<Exception>(() => bookService.Put(101, book));
        }

        [Fact]
        public void Delete_CountOfList_1()
        {
            bookService.Delete(101);
            List<Book> bookList = bookService.Get();
            Assert.Equal(1, bookList.Count);
        }

    }
    
}

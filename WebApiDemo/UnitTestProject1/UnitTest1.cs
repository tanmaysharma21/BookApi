using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiDemo.Service;
using WebApiDemo.Model;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_CountOfList_2()
        {
            BookService bookService = new BookService();
            List<Book> bookList = bookService.Get();
            Assert.AreEqual(2, bookList.Count);
            //Assert.Equal(2, bookList.Count);
        }
    }
}

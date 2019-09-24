using System;
using System.Collections.Generic;
using WebApiDemo.ApiReturnModel;
using WebApiDemo.Model;
using WebApiDemo.Service;
using Xunit;

namespace CoreTest
{
    public class UnitTest1
    {
        BookService bookService;
        ApiModel apiModel;
        public UnitTest1()
        {
            bookService = new BookService();
            apiModel = new ApiModel();
        }

        [Fact]
        public void Get_CountOfApiRequestResultList_2()
        {
            
            bookService.Get(apiModel);
            Assert.Equal(2, apiModel.apiRequestResult.Count);
        }

        [Fact]
        public void Get_CountOfErrorList_0()
        {
            bookService.Get(apiModel);
            Assert.Empty(apiModel.errorList);
        }

        [Fact]
        public void Get_InvalidId_CountOfErrorList_1()
        {
            bookService.Get(32, apiModel);
            Assert.Single(apiModel.errorList);
        }

        [Fact]
        public void Get_ValidId_CountOfErrorList_0()
        {
            bookService.Get(101, apiModel);
            Assert.Empty(apiModel.errorList);
        }

        [Fact]
        public void Get_ValidId_CountOfApiRequestResultList_1()
        {
            bookService.Get(101, apiModel);
            Assert.Single(apiModel.apiRequestResult);
        }

        [Fact]
        public void Post_ValidBook_CountOfErrorList_0()
        {
            bookService.Post(new Book() { Name = "Flights", Author = "APJ", Category = "Fiction", Id = 231, Price = 732 }, apiModel);
            Assert.Empty(apiModel.errorList);
        }

        [Fact]
        public void Post_InalidBook_CountOfErrorList_1()
        {
            bookService.Post(new Book() { Author = "APJ", Category = "Fiction", Id = 231, Price = 732 }, apiModel);
            Assert.Single(apiModel.errorList);
        }

        [Fact]
        public void Post_InalidBook_CountOfErrorList_2()
        {
            bookService.Post(new Book() { Author = "APJ", Category = "Fict232ion", Id = 231, Price = 732 }, apiModel);
            Assert.Equal(2, apiModel.errorList.Count);
        }

        [Fact]
        public void Put_InvalidId_CountOfErrorList_1()
        {
            bookService.Put(32, new Book() { Name = "Flights", Author = "APJ", Category = "Fiction", Id = 231, Price = 732 }, apiModel);
            Assert.Single(apiModel.errorList);
        }

        [Fact]
        public void Put_InvalidBook_CountOfErrorList_2()
        {
            bookService.Put(101, new Book() { Name = "Fli32ghts", Author = "APJ", Category = "Fiction", Id = 231 }, apiModel);
            Assert.Equal(2, apiModel.errorList.Count);
        }

        [Fact]
        public void Put_InvalidId_And_InvalidBook_CountOfErrorList_2()
        {
            bookService.Put(32, new Book() { Name = "Fli32ghts", Author = "APJ", Category = "Fiction", Id = 231 }, apiModel);
            Assert.Equal(3, apiModel.errorList.Count);
        }

        [Fact]
        public void Put_ValidId_And_ValidBook_CountOfErrorList_0()
        {
            bookService.Put(101, new Book() { Name = "Flights", Author = "APJ", Category = "Fiction", Id = 231, Price = 732 }, apiModel);
            Assert.Empty(apiModel.errorList);
        }

        [Fact]
        public void Delete_InvalidId_CountOfErrorList_1()
        {
            bookService.Delete(43, apiModel);
            Assert.Single(apiModel.errorList);
        }

        [Fact]
        public void Delete_ValidId_CountOfErrorList_0()
        {
            bookService.Delete(101, apiModel);
            Assert.Empty(apiModel.errorList);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.ApiReturnModel;
using WebApiDemo.Database;
using WebApiDemo.Model;
using WebApiDemo.Validator;

namespace WebApiDemo.Service
{
    public class BookService
    {
        public BookData bookData = new BookData();
        public BookValidator bookValidator = new BookValidator();

        public void Get(ApiModel apiModel)
        {
            bookData.GetBooks(apiModel);
        }

        public void Get(int id, ApiModel apiModel)
        {
            bookValidator.ValidateApiId(id, apiModel);
            if (apiModel.errorList.Count == 0)
                bookData.GetBookById(id, apiModel);
        }

        public void Post(Book book, ApiModel apiModel)
        {
            bookValidator.ValidateBook(book, apiModel);
            if (apiModel.errorList.Count == 0)
                bookData.Add(book);
        }


        public void Put(int id, Book book, ApiModel apiModel)
        {
            bookValidator.ValidateApiId(id, apiModel);
            bookValidator.ValidateBook(book, apiModel);
            bookData.Update(id, book, apiModel);
        }

        public void Delete(int id, ApiModel apiModel)
        {
            bookValidator.ValidateApiId(id, apiModel);
            if (apiModel.errorList.Count==0)
                bookData.DeleteBook(id, apiModel);
        }

    }
}

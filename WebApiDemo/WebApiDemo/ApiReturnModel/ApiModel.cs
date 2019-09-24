using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Errors;
using WebApiDemo.Model;

namespace WebApiDemo.ApiReturnModel
{
    public class ApiModel
    {
        public List<Book> apiRequestResult = new List<Book>();
        public List<Error> errorList = new List<Error>();
        private ApiError _apiError = new ApiError();

        public void AddError(string errorName)
        {
            errorList.Add(_apiError.GetError(errorName));
        }

        public void AddBookList(List<Book> bookList)
        {
            apiRequestResult.AddRange(bookList);
        }

        public void AddBook(Book book)
        {
            apiRequestResult.Add(book);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.ApiReturnModel;
using WebApiDemo.Model;

namespace WebApiDemo.Validator
{
    public class BookValidator
    {
        public void ValidateBook(Book book, ApiModel apiModel)
        {
            if (book.Id <= 0)
                apiModel.AddError("InvalidId");
            if (book.Price <= 0)
                apiModel.AddError("InvalidPrice");
            if (book.Name == null)
                apiModel.AddError("NullBookName");
            else
            {
                foreach(char character in book.Name)
                {
                    int x = (int)character;
                    if (x<65 || (x>90 && x<97) || x > 122)
                    {
                        apiModel.AddError("InvalidBookName");
                        break;
                    }
                }
            }
            if (book.Author == null)
                apiModel.AddError("NullBookAuthor");
            else
            {
                foreach (char character in book.Author)
                {
                    int x = (int)character;
                    if (x < 65 || (x > 90 && x < 97) || x > 122)
                    {
                        apiModel.AddError("InvalidBookAuthor");
                        break;
                    }
                }
            }
            if (book.Category == null)
                apiModel.AddError("NullBookCategory");
            else
            {
                foreach (char character in book.Category)
                {
                    int x = (int)character;
                    if (x < 65 || (x > 90 && x < 97) || x > 122)
                    {
                        apiModel.AddError("InvalidBookCategory");
                        break;
                    }
                }
            }

            //if (book.Id <= 0)
            //    return false;
            //if (book.Name == null || book.Author == null || book.Category == null)
            //    return false;
            //if (book.Price <= 0)
            //    return false;
            //return true;
        }

        public void ValidateApiId(int id, ApiModel apiModel)
        {
            if (id <= 0)
            {
                apiModel.AddError("InvalidApiId");
            }
        }

    }
}

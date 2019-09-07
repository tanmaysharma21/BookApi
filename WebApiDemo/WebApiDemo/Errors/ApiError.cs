using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Errors
{
    public class ApiError
    {
        public Error GetError(string errorName)
        {
            switch (errorName.ToLowerInvariant())
            {
                case "invalidapiid":
                    return new Error(416, "Invalid API id : Id must be greater than 0");
                case "booknotpresent":
                    return new Error(404, "Book of given id not found");
                case "invalidid":
                    return new Error(400, "Invalid Book Id. It must be greater than 0");
                case "invalidprice":
                    return new Error(400, "Invalid Book Price. It must be greater than 0");
                case "nullbookname":
                    return new Error(400, "Invalid Book Name. It must not be null.");
                case "invalidbookname":
                    return new Error(400, "Invalid Book Name. It must contain characters only.");
                case "nullbookauthor":
                    return new Error(400, "Invalid Author Name. It must not be null.");
                case "invalidbookauthor":
                    return new Error(400, "Invalid Author Name. It must contain characters only.");
                case "nullbookcategory":
                    return new Error(400, "Invalid Category Name. It must not be null.");
                case "invalidbookcategory":
                    return new Error(400, "Invalid Category Name. It must contain characters only.");
                default:
                    return new Error(412, "PRECONDITION FAILED");
            }
        }
    }
}

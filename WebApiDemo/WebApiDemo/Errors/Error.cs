using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Errors
{
    public class Error
    {
        public int Code { get; private set; }
        public string Message { get; private set; }
        public Error(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}

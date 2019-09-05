using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Service;
using WebApiDemo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        public BookService bookService = new BookService();
        // GET: api/book
        [HttpGet]
        public List<Book> Get()
        {
            return bookService.Get();
        }

        // GET api/book/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return bookService.Get(id);
        }

        // POST api/book
        [HttpPost]
        public void Post([FromBody]Book book)
        {
            bookService.Post(book);
        }

        // PUT api/book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Book book)
        {
            bookService.Put(id, book);
        }

        // DELETE api/book/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bookService.Delete(id);
        }
    }
}

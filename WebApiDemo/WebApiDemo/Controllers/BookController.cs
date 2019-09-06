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
        public ActionResult<List<Book>> Get()
        {
            try
            {
                return Ok(bookService.Get());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET api/book/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            try
            {
                return Ok(bookService.Get(id));
            }
            catch
            {
                return NotFound();
            }
        }

        // POST api/book
        [HttpPost]
        public ActionResult Post([FromBody]Book book)
        {
            try
            {
                return Ok(bookService.Post(book));
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT api/book/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Book book)
        {
            try
            {
                return Ok(bookService.Put(id, book));
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE api/book/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(bookService.Delete(id));
            }
            catch
            {
                return NotFound();
            }
                
        }
    }
}

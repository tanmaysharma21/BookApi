using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Service;
using WebApiDemo.Model;
using WebApiDemo.ApiReturnModel;

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
            ApiModel apiModel = new ApiModel();
            bookService.Get(apiModel);
            if (apiModel.errorList.Count == 0)
                return Ok(apiModel.apiRequestResult);
            return NotFound(apiModel.errorList);
        }

        // GET api/book/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            ApiModel apiModel = new ApiModel();
            bookService.Get(id, apiModel);
            if (apiModel.errorList.Count == 0)
                return Ok(apiModel.apiRequestResult);
            return NotFound(apiModel.errorList);
        }

        // POST api/book
        [HttpPost]
        public ActionResult Post([FromBody]Book book)
        {
            ApiModel apiModel = new ApiModel();
            bookService.Post(book, apiModel);
            if (apiModel.errorList.Count == 0)
                return Ok();
            return BadRequest(apiModel.errorList);
        }

        // PUT api/book/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Book book)
        {
            ApiModel apiModel = new ApiModel();
            bookService.Put(id, book, apiModel);
            if (apiModel.errorList.Count == 0)
                return Ok();
            return BadRequest(apiModel.errorList);
        }

        // DELETE api/book/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ApiModel apiModel = new ApiModel();
            bookService.Delete(id, apiModel);
            if (apiModel.errorList.Count == 0)
                return Ok();
            return NotFound(apiModel.errorList);
        }
    }
}

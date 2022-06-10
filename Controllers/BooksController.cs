using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return BookRepository.GetAllBooks();

        }


        [HttpPost]
        public IActionResult Post(Book book)
        {
            try
            {
                BookRepository.SaveBook(book);

                return Ok();


            }
            catch (Exception e)
            {

                return NotFound();
            }


        }


        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            try
            {
                BookRepository.DeleteBook(Id);
                return Ok();
            }
            catch (Exception)
            {

                return NotFound();

            }







        }


        //Not Working
        [HttpPut]
        public IActionResult Put([FromBody]Book book)
        {
            try
            {
                BookRepository.UpdateBook(book);
                return Ok();
            }
            catch (Exception)
            {

                return NotFound();

            }


        }
    }
}

using _13285_egzamin_asp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _13285_egzamin_asp.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> books = new List<Book>()
        {
            new Book(){Id=1, Title="AAAA", Author="BBBB", Price=100},
            new Book(){Id=2, Title="CCCC", Author="DDDD", Price=50},
            new Book(){Id=3, Title="EEEE", Author="FFFF", Price=10}

        };
        
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var zmienna = books.Where(x => x.Id.Equals(id)).First();
            if (zmienna != null)
            {
                int index = id - 1;
                books.RemoveAt(index);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }


    }

}


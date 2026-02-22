using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FirstAPI.models;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class booksController : Controller
    {
        static private List<Book> books = new List<Book>
        {
             new Book
             { Id = 1,
               Title = "Fountain Head",
               Author = "Ayn Rand",
               YearPublished = "1958"
             },
             new Book
             { Id = 2,
               Title = "Thus Spake Zarathusthra",
               Author = "Friedrick Nietzsche",
               YearPublished = "1960"
             },
             new Book{
                 Id = 3,
               Title = "Atlas Shrigged",
               Author = "Ayn Rand",
               YearPublished = "1970"
             }
             
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpGet]
        public ActionResult<List<Book>> GetBooksbyId(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

    }   
}

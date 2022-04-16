using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
             new Book{Id=1,title="Lean Startup",GenreId=1,PageCount=200,PublishDate=new DateTime(2001,06,12)},
             new Book{Id=2,title="Herland",GenreId=2,PageCount=250,PublishDate=new DateTime(2010,05,23)},
             new Book{Id=3,title="Dune",GenreId=3,PageCount=300,PublishDate=new DateTime(2020,7,25)},
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(book => book.Id == id).SingleOrDefault();
            return book;
        }
        /* 
        [HttpGet]
        public Book Get([FromQuery] string id)
        {
            var book = BookList.Where(book => book.Id == Convert.ToInt32(id)).SingleOrDefault();
            return book;
        }
         */

        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = BookList.SingleOrDefault(x => x.title == newBook.title);
            if (book is not null)
            {
                return BadRequest();
            }
            BookList.Add(newBook);
            return Ok();
        }

        [HttpPut("{id}")]

        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = BookList.SingleOrDefault(x => x.Id == id);
            if (book is null)
            {
                return BadRequest();
            }
            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.title = updatedBook.title != default ? updatedBook.title : book.title;
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id){
            var book=BookList.SingleOrDefault(x=>x.Id==id);
            if(book is null)
            return BadRequest();

            BookList.Remove(book);
            return Ok();
        }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TietoAcademyDemo.Application;
using TietoAcademyDemo.Domain;
using TietoAcademyDemo.Infrastructure;

namespace TietoAcademyDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        //[HttpGet("test")]
        //public string[] GetBooks()
        //{
        //    return new string[] { "Book 1", "Book 2" };
        //}

        [HttpGet("{isbn}")]
        public ActionResult<Book> GetBook(string isbn)
        {
            return _booksService.GetBook(isbn);
        }

        //// /books
        //[HttpGet]
        //public List<string> GetAllBooks()
        //{
        //    var books = _booksService.GetBooks();

        //    return books;
        //}

        // /books
        [HttpGet]
        public IEnumerable<Book> GetAllBooksDI()
        {
            var books = _booksService.GetBooks();

            return books;
        }

        // /books
        [HttpDelete]
        public void RemoveBook([FromBody] Book book)
        {
           // _booksService.RemoveBook(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook([FromBody] Book book)
        {
            _booksService.AddBook(book);

            return book;
        }

    }
}
using System.Collections.Generic;
using System.Linq;
using TietoAcademyDemo.Application;
using TietoAcademyDemo.Domain;
using TietoAcademyDemo.Persistence;

namespace TietoAcademyDemo.Infrastructure
{
    public class BooksService2 : IBooksService
    {
        private readonly BooksContext _context;

        public BooksService2(BooksContext context)
        {
            _context = context;
        }

        public Book AddBook(Book book)
        {
            _context.Books.Add(book);

            _context.SaveChanges();

            return book;
        }

        public Book GetBook(string isbn)
        {
            Book book = _context.Books.SingleOrDefault(x => x.isbn == isbn);

            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }

        public void RemoveBook(string isbn)
        {
            //throw new System.NotImplementedException();
            Book book = _context.Books.SingleOrDefault(x => x.isbn == isbn);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book RenameBook(string isbn, string newName)
        {
            throw new System.NotImplementedException();
        }
    }
}

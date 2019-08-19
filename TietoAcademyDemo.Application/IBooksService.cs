using System.Collections.Generic;
using TietoAcademyDemo.Domain;

namespace TietoAcademyDemo.Application
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(string isbn);
        Book AddBook(Book book);
        Book RenameBook(string isbn, string newName);
        void RemoveBook(string isbn);
    }
}

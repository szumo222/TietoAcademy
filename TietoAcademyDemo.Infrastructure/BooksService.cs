using System.Collections.Generic;
using TietoAcademyDemo.Application;
using TietoAcademyDemo.Domain;

namespace TietoAcademyDemo.Infrastructure
{
    public class BooksService : IBooksService
    {
        public List<string> Books = new List<string>{ "In Search of Lost Time", "Don Quixote by Miguel de Cervantes",
            "Ulysses", "The Great Gatsby", "Moby Dick" };

        public List<Book> Books2 = new List<Book>
        {
            new Book() {
                isbn = "1",
                title = "In Search of Lost Time"
            },
            new Book() {
                isbn = "2",
                title = "Don Quixote by Miguel de Cervantes"
            },
            new Book() {
                isbn = "3",
                title = "Ulysses"
            }
        };

        //public List<string> GetBooks()
        //{
        //    return Books;
        //}

        public IEnumerable<Book> GetBooks()
        {
            return Books2;
        }

        public Book GetBook(string isbn)
        {
            throw new System.NotImplementedException();
        }

        public Book AddBook(Book book)
        {
            Books2.Add(book);

            return book;
        }

        public Book RenameBook(string isbn, string newName)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveBook(string isbn)
        {
            throw new System.NotImplementedException();
        }
    }
}

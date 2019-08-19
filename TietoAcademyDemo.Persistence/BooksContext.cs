using Microsoft.EntityFrameworkCore;
using TietoAcademyDemo.Domain;

namespace TietoAcademyDemo.Persistence
{
    public class BooksContext : DbContext
    {
        // Entities
        public DbSet<Book> Books { get; set; }

        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
        }
    }
}

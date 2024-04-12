using Microsoft.EntityFrameworkCore;

namespace lab3.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<Style> Styles { get; set; } = null!; 
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { Database.EnsureCreated(); }
    }
}

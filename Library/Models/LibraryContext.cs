using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<LibrarianUser>
  {
    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Genre> Genres { get; set; }
    public virtual DbSet<AuthorBook> AuthorBook { get; set; }
    public virtual DbSet<BookGenre> BookGenre { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}
using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Library.Models
{
  public class Book

  {
    public int BookId { get; set; }
    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public bool IsAvailable { get; set; }

    public ICollection<AuthorBook> Authors { get; set; }
    public ICollection<BookGenre> Genres { get; set; }
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      this.Genres = new HashSet<BookGenre>();

    }

  }
}
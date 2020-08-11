using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Library.Models
{
  public class Genre

  {
    public int GenreId { get; set; }
    public string Name { get; set; }

    public ICollection<BookGenre> Books { get; set; }
    public Genre()
    {
      this.Books = new HashSet<BookGenre>();
    }

  }
}
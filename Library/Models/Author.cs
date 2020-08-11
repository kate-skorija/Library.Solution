using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace Library.Models
{
  public class Author

  {
    public int AuthorId { get; set; }
    public string FullName { get; set; }
    public virtual ICollection<AuthorBook> Books { get; set; }

    public Author()
    {
      this.Books = new HashSet<AuthorBook>();
    }
  }
}
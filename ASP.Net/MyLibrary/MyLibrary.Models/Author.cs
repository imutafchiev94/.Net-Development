using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public class Author
    {

        public Author()
        {
            this.Books = new List<Book>();
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Book> Books { get; set; }

    }
}

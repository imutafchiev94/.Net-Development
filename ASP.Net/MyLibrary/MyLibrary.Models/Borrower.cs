using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibrary.Models
{
    public class Borrower
    {

        public Borrower()
        {
            this.Books = new List<BookBorrower>();
        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public IEnumerable<BookBorrower> Books { get; set; }

    }
}

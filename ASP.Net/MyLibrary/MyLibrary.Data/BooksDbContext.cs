using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using System;

namespace MyLibrary.Data
{
    public class BooksDbContext : IdentityDbContext<IdentityUser>
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }

        public DbSet<BookBorrower> BookBorrowers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Author>(a =>
            a.HasMany(b => b.Books)
            .WithOne(at => at.Author)
            .HasForeignKey(b => b.AuthorId));

            builder.Entity<BookBorrower>(b =>
            b.HasKey(bb => new { bb.BookId, bb.BorrowerId }));

            base.OnModelCreating(builder);
        }
    }
}

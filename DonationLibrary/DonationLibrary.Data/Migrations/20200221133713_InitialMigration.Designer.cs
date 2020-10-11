﻿// <auto-generated />
using DonationLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DonationLibrary.Data.Migrations
{
    [DbContext(typeof(BooksDbContext))]
    [Migration("20200221133713_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DonationLibrary.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DonationLibrary.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("BookCoverImageUrl");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<double>("DonatedPrice");

                    b.Property<string>("DonationStatus")
                        .IsRequired();

                    b.Property<int>("RecipientId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DonationLibrary.Models.BookRecipient", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("RecipientId");

                    b.HasKey("BookId", "RecipientId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.HasIndex("RecipientId");

                    b.ToTable("BookRecipient");
                });

            modelBuilder.Entity("DonationLibrary.Models.Recipient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<double>("DonatedMoney");

                    b.Property<string>("DonationAccount")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PictureURL");

                    b.HasKey("Id");

                    b.ToTable("Recipients");
                });

            modelBuilder.Entity("DonationLibrary.Models.Book", b =>
                {
                    b.HasOne("DonationLibrary.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DonationLibrary.Models.BookRecipient", b =>
                {
                    b.HasOne("DonationLibrary.Models.Book", "Book")
                        .WithOne("Recipient")
                        .HasForeignKey("DonationLibrary.Models.BookRecipient", "BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DonationLibrary.Models.Recipient", "Recipient")
                        .WithMany("DonatedBooks")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

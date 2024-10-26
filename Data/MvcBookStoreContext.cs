using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBookStore.Models;

namespace MvcBookStore.Data
{
    public class MvcBookStoreContext : DbContext
    {
        public MvcBookStoreContext(DbContextOptions<MvcBookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBookStore.Models.Book> Book { get; set; } = default!;

        public DbSet<MvcBookStore.Models.Author>? Author { get; set; }

        public DbSet<MvcBookStore.Models.Genre>? Genre { get; set; }

        public DbSet<MvcBookStore.Models.Review>? Review { get; set; }

        public DbSet<BookGenre> BookGenre { get; set; }

        public DbSet<UserBooks> UserBooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserBooks>()
                .HasKey(ub => new { ub.Id });

            modelBuilder.Entity<UserBooks>()
                .HasOne(ub => ub.Book)
                .WithMany(eb => eb.UserBooks)
                .HasForeignKey(ub => ub.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId);

            modelBuilder.Entity<BookGenre>()
                .HasKey(bg => new { bg.BookId, bg.GenreId });

            modelBuilder.Entity<BookGenre>()
                .HasOne(bg => bg.Book)
                .WithMany(b => b.Books)
                .HasForeignKey(bg => bg.BookId);

            modelBuilder.Entity<BookGenre>()
                .HasOne(bg => bg.Genre)
                .WithMany(g => g.Genres)
                .HasForeignKey(bg => bg.GenreId);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }

    }
}
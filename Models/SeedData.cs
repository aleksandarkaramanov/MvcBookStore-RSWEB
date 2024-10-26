using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MvcBookStore.Models;

namespace MvcBookStore.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookStoreContext>>()))
            {
                // Check if authors already exist in the database
                context.Author.RemoveRange(context.Author);
                context.Book.RemoveRange(context.Book);
                context.Genre.RemoveRange(context.Genre);
                context.Review.RemoveRange(context.Review);
                context.BookGenre.RemoveRange(context.BookGenre);
                context.SaveChanges();

                context.Author.AddRange(
                    new Author
                    {
                        FirstName = "J.K.",
                        LastName = "Rowling",
                        BirthDate = new DateTime(1965, 7, 31),
                        Nationality = "British",
                        Gender = "Female"
                    },
                    new Author
                    {
                        FirstName = "George",
                        LastName = "Orwell",
                        BirthDate = new DateTime(1903, 6, 25),
                        Nationality = "British",
                        Gender = "Male"
                    }
                );
                context.SaveChanges();

                context.Book.AddRange(
                    new Book
                    {
                        Title = "To Kill a Mockingbird",
                        YearPublished = 1960,
                        NumPage = 336,
                        Description = "A gripping, heart-wrenching, and wholly remarkable tale of coming-of-age in a South poisoned by virulent prejudice.",
                        Publisher = "Harper Lee",
                        FrontPage = "C:\\Users\\HP\\source\\repos\\MvcBookStore\\Images\\book1.jpg",
                        DownloadUrl = "https://www.pdfdrive.com/to-kill-a-mockingbird-pdf-e188405471.html",
                        Author = new Author
                        {
                            FirstName = "Harper",
                            LastName = "Lee",
                            BirthDate = new DateTime(1926, 4, 28),
                            Nationality = "American",
                            Gender = "Female"
                        }
                    },
                    new Book
                    {
                        Title = "In Search of Lost Time",
                        YearPublished = 1913,
                        NumPage = 336,
                        Description = "Marcel Proust’s In Search of Lost Time is one of the most entertaining reading experiences in any language and arguably the finest novel of the twentieth century.",
                        Publisher = "Marcel ",
                        FrontPage = "https://m.media-amazon.com/images/I/51Wrlbko5QL.jpg",
                        DownloadUrl = "https://www.amazon.com/Swanns-Way-Penguin-Classics-Edition-ebook/dp/B004GUTMJK%3FSubscriptionId%3D1RN7ZZ7D7SDQHR7TRJG2%26tag%3Dshanesherman-20%26linkCode%3Dxm2%26camp%3D2025%26creative%3D165953%26creativeASIN%3DB004GUTMJK?asin=B004GUTMJK&revisionId=2e3491b9&format=1&depth=1",
                        Author = new Author
                        {
                            FirstName = "Marcel ",
                            LastName = "Proust",
                            BirthDate = new DateTime(1871, 7, 11),
                            Nationality = "French",
                            Gender = "Male"
                        }
                    },
                    new Book
                    {
                        Title = "In Search of Lost Time",
                        YearPublished = 1960,
                        NumPage = 336,
                        Description = "isoned by virulent prejudice.",
                        Publisher = "Harper ",
                        FrontPage = "https://upload.wikimedia.org/wikipedia/en/7/79/To_Kill_a_Mockingbird.JPG",
                        DownloadUrl = "https://www.pdfdrive.com/to-kill-a-mockingbird-pdf-e188405471.html",
                        Author = new Author
                        {
                            FirstName = "Shashi ",
                            LastName = "Tharoor",
                            BirthDate = new DateTime(1926, 4, 28),
                            Nationality = "American",
                            Gender = "Female"
                        }
                    }
                    );
                    context.SaveChanges();


                context.Genre.AddRange(
                    new Genre
                    {
                        GenreName = "Comedy"
                    },
                    new Genre
                    {
                        GenreName = "Action"
                    },
                    new Genre
                    {
                        GenreName = "Drama"
                    },
                    new Genre
                    {
                        GenreName = "Triler"
                    }

                    );

                context.SaveChanges();
                context.Review.AddRange(
                new Review
                {
                    AppUser = "john@example.com",
                    Comment = "Good book",
                    Rating = 5,
                    BookId = 16,
                }
                );
                context.SaveChanges();
                    
               


                context.BookGenre.AddRange(
                new BookGenre
                {
                    BookId =16,
                    GenreId =21,
                }
                );
                context.SaveChanges();

            }
        }
    }
}
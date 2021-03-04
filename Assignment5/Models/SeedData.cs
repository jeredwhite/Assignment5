using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    //Pre-load books to DB
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Fiction",
                        Genre = "Classic",
                        Price = 9.95F,
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Non-Fiction",
                        Genre = "Biography",
                        Price = 14.58F,
                        Pages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Non-Fiction",
                        Genre = "Biography",
                        Price = 21.54F,
                        Pages = 832
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Non-Fiction",
                        Genre = "Self-Help",
                        Price = 14.99F,
                        Pages = 304
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Non-Fiction",
                        Genre = "Historical",
                        Price = 13.33F,
                        Pages = 528
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category = "Non-Fiction",
                        Genre = "Biography",
                        Price = 11.61F,
                        Pages = 864
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Fiction",
                        Genre = "Historical Fiction",
                        Price = 15.95F,
                        Pages = 288
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Non-Fiction",
                        Genre = "Self-Help",
                        Price = 21.66F,
                        Pages = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Non-Fiction",
                        Genre = "Business",
                        Price = 29.16F,
                        Pages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Fiction",
                        Genre = "Thrillers",
                        Price = 15.03F,
                        Pages = 642
                    },

                    new Book
                    {
                        Title = "Hatchet",
                        AuthorFirst = "Gary",
                        AuthorLast = "Paulsen",
                        Publisher = "Simon & Schuster",
                        ISBN = "9781416925088",
                        Category = "Fiction",
                        Genre = "Adventure",
                        Price = 15.88F,
                        Pages = 198
                    },

                    new Book
                    {
                        Title = "The Book of Mormon",
                        AuthorFirst = "Mormon",
                        AuthorLast = "",
                        Publisher = "Harmony",
                        ISBN = "9780385513166",
                        Category = "Gospel",
                        Genre = "Religious",
                        Price = 17.90F,
                        Pages = 531
                    },

                    new Book
                    {
                        Title = "The Giver",
                        AuthorFirst = "Lois",
                        AuthorLast = "Lowry",
                        Publisher = "Houghton Mifflin Harcourt",
                        ISBN = "9780547424774",
                        Category = "Fiction",
                        Genre = "SciFi",
                        Price = 39.13F,
                        Pages = 222
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

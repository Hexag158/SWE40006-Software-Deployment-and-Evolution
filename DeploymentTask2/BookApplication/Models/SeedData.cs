using Microsoft.EntityFrameworkCore;
using RazorPagesBook.Data;
using RazorPagesBook.Models;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesBookContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesBookContext>>()))
        {
            if (context == null || context.Book == null)
            {
                throw new ArgumentNullException("Null RazorPagesBookContext");
            }

            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    StartDate = DateTime.Parse("2022-1-1"),
                    FinishDate = DateTime.Parse("2022-2-1"),
                    Genre = "Fiction",
                    Progress = 100,
                    Rating = 4.8,
                    Author = "Harper Lee"
                },

                new Book
                {
                    Title = "1984",
                    StartDate = DateTime.Parse("2022-3-1"),
                    FinishDate = DateTime.Parse("2022-4-1"),
                    Genre = "Dystopian",
                    Progress = 100,
                    Rating = 4.7,
                    Author = "George Orwell"
                },

                new Book
                {
                    Title = "Pride and Prejudice",
                    StartDate = DateTime.Parse("2022-1-28"),
                    FinishDate = DateTime.Parse(""),
                    Genre = "Romance",
                    Progress = 89,
                    Rating = 4.6,
                    Author = "Jane Austen"
                },

                new Book
                {
                    Title = "The Great Gatsby",
                    StartDate = DateTime.Parse("2022-5-1"),
                    FinishDate = DateTime.Parse("2022-5-15"),
                    Genre = "Fiction",
                    Progress = 100,
                    Rating = 4.5,
                    Author = "F. Scott Fitzgerald"
                }
            );


            context.SaveChanges();
        }
    }
}
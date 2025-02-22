using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie { Title = "The Matrix", ReleaseDate = new DateTime(1999, 3, 31), Genre = "Science Fiction", Price = 9.99m, Rating = "R" },
                new Movie { Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Action", Price = 14.99m, Rating = "PG-13" },
                new Movie { Title = "Interstellar", ReleaseDate = new DateTime(2014, 11, 7), Genre = "Adventure", Price = 10.99m, Rating = "PG-13" },
                new Movie { Title = "Parasite", ReleaseDate = new DateTime(2019, 10, 11), Genre = "Thriller", Price = 11.99m, Rating = "R" },
            );
            context.SaveChanges();
        }
    }
}
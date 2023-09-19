using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CaesarMovie.Data;
using System;
using System.Linq;

namespace CaesarMovie.Models;
public static class SeedData
{

    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CaesarMovieContext(serviceProvider.GetRequiredService<DbContextOptions<CaesarMovieContext>>()))
        {
            if (context.Movie.Any())
            {
                return; //db has initial data and is seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "Caesar the Top Engineer",
                    ReleaseDate = DateTime.Parse("1991-11-10"),
                    Genre = "Thriller",
                    Price = 12.45M
                },
                 new Movie
                 {
                     Title = "Tobi and Ifemi",
                     ReleaseDate = DateTime.Parse("1989-09-15"),
                     Genre = "Thriller",
                     Price = 72.08M
                 },
                 new Movie
                 {
                     Title = "Ife the stubborn",
                     ReleaseDate = DateTime.Parse("1996-06-09"),
                     Genre = "Comedy",
                     Price = 8.27M
                 },
                 new Movie
                 {
                     Title = "David Dreamer",
                     ReleaseDate = DateTime.Parse("1999-04-02"),
                     Genre = "Romance",
                     Price = 11.11M
                 }
            );
            context.SaveChanges();


        }
    }
}
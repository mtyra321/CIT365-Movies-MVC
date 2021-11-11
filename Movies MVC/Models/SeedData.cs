using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies_MVC.Data;
using System;
using System.Linq;

namespace Movies_MVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Movies_MVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Movies_MVCContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-9-9"),
                        Genre = "Comedy",
                        Rating = "PG", 
                        Price = 7.99M,
                        PictureURL = "mobsters_and_mormons.jpg"

                    },

                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M,
                        PictureURL = "the_R_M.jpg"

                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M,
                        PictureURL = "the_best_two_years.jpg"

                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-1-30"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 3.99M,
                        PictureURL = "the_singles_ward.jpg"

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
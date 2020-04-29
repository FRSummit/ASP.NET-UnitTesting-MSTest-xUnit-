using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Avengers - Age Of Ultron 1",
                        ReleaseDate = DateTime.Parse("2012-03-15"),
                        Genre = "Action Movie 1",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "Avengers - Age Of Ultron 2",
                        ReleaseDate = DateTime.Parse("2012-03-16"),
                        Genre = "Action Movie 2",
                        Price = 8
                    },
                    new Movie
                    {
                        Title = "Avengers - Age Of Ultron 3",
                        ReleaseDate = DateTime.Parse("2012-03-17"),
                        Genre = "Action Movie 3",
                        Price = 9
                    },
                    new Movie
                    {
                        Title = "Avengers - Age Of Ultron 4",
                        ReleaseDate = DateTime.Parse("2012-03-18"),
                        Genre = "Action Movie 4",
                        Price = 6
                    },
                    new Movie
                    {
                        Title = "Avengers - Age Of Ultron 5",
                        ReleaseDate = DateTime.Parse("2012-03-19"),
                        Genre = "Action Movie 5",
                        Price = 5
                    },
                    new Movie
                    {
                        Title = "Avengers - Age Of Ultron 6",
                        ReleaseDate = DateTime.Parse("2012-03-25"),
                        Genre = "Action Movie 6",
                        Price = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

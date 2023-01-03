using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeds;

public static class DefaultMovieSeed
{
    public static void MovieSeed(this ModelBuilder modelBuilder)
    {
        // default seed
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                MovieId = 1,
                Title = "BlackPantherWakandaForEver",
                MovieYear = 2022,
                CategoryId = 1
            },
            new Movie
            {
                MovieId = 2,
                Title = "BoboiGhaffor",
                MovieYear = 2016,
                CategoryId = 2

            },
            new Movie
            {
                MovieId = 3,
                Title = "SpiderMan",
                MovieYear = 2015,
                CategoryId = 3
            },
            new Movie
            {
                MovieId = 4,
                Title = "Panda",
                MovieYear = 2016,
                CategoryId = 1
            }
        );
    }
}

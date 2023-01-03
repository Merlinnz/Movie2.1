using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeds;

public static class DefaultActorSeed
{
    public static void ActorSeed(this ModelBuilder modelBuilder)
    {
        // default seed
        modelBuilder.Entity<Actor>().HasData(
            new Actor
            {
                ActorId = 1,
                FullName = "Chadwick Boseman",
                Gender = 1,
                BirthYear = 2000,
                DeathYear = 2041
            },
            new Actor
            {
                ActorId = 2,
                FullName = "Jack Chan",
                Gender = 1,
                BirthYear = 1990,
                DeathYear = 2022
            },
            new Actor
            {
                ActorId = 3,
                FullName = "Chris Evans",
                Gender = 1,
                BirthYear = 1989,
                DeathYear = 1997
            }
        );
    }
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeds;

public static class DefaultCategorySeed
{
    public static void CategorySeed(this ModelBuilder modelBuilder)
    {
        // default seed
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                CategoryName = "Action"
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Comedy"
            },
            new Category
            {
                CategoryId = 3,
                CategoryName = "Fantasy"
            }
        );
    }
}
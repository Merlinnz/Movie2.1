using Domain.Entities;
using Infrastructure.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options)
    {
        
    }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cast>().HasKey(am => new { am.ActorId, am.MovieId});

        modelBuilder.Entity<Cast>()
        .HasOne<Actor>(am => am.Actor)
        .WithMany(a => a.Casts)
        .HasForeignKey(am => am.ActorId);


        modelBuilder.Entity<Cast>()
        .HasOne<Movie>(am => am.Movie)
        .WithMany(a => a.Casts)
        .HasForeignKey(am => am.MovieId);



        modelBuilder.MovieSeed();
        modelBuilder.CategorySeed();
        modelBuilder.ActorSeed();
    }
}
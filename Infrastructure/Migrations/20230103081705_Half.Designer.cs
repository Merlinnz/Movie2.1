// <auto-generated />
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230103081705_Half")]
    partial class Half
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ActorId"));

                    b.Property<int>("BirthYear")
                        .HasColumnType("integer");

                    b.Property<int>("DeathYear")
                        .HasColumnType("integer");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            BirthYear = 2000,
                            DeathYear = 2041,
                            FullName = "Chadwick Boseman",
                            Gender = 1
                        },
                        new
                        {
                            ActorId = 2,
                            BirthYear = 1990,
                            DeathYear = 2022,
                            FullName = "Jack Chan",
                            Gender = 1
                        },
                        new
                        {
                            ActorId = 3,
                            BirthYear = 1989,
                            DeathYear = 1997,
                            FullName = "Chris Evans",
                            Gender = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Cast", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Title = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            Title = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            Title = "Fantasy"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MovieId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("MovieYear")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            MovieYear = 2022,
                            Title = "BlackPantherWakandaForEver"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            MovieYear = 2016,
                            Title = "BoboiGhaffor"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            MovieYear = 2015,
                            Title = "SpiderMan"
                        },
                        new
                        {
                            MovieId = 4,
                            CategoryId = 1,
                            MovieYear = 2016,
                            Title = "Panda"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Cast", b =>
                {
                    b.HasOne("Domain.Entities.Actor", "Actor")
                        .WithMany("Casts")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany("Casts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Entities.Actor", b =>
                {
                    b.Navigation("Casts");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Navigation("Casts");
                });
#pragma warning restore 612, 618
        }
    }
}

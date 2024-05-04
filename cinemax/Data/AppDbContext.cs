using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cinemax.Models;

namespace cinemax.Data
{
  public class AppDbContext : DbContext
  {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Actor_Movie>()
          .HasKey(am => new { am.ActorId, am.MovieId }); // Use 'am' for Actor_Movie entity

      modelBuilder.Entity<Actor_Movie>()
          .HasOne(am => am.Movie) // Use 'am' for Actor_Movie entity
          .WithMany(m => m.Actors_Movies)
          .HasForeignKey(am => am.MovieId);

      modelBuilder.Entity<Actor_Movie>()
          .HasOne(am => am.Actor) // Use 'am' for Actor_Movie entity
          .WithMany(m => m.Actors_Movies)
          .HasForeignKey(am => am.ActorId);

      base.OnModelCreating(modelBuilder);
    }

    public DbSet<Actor> Actors { get; set; }

    public DbSet<Movie> Movies { get; set; } // Fix typo with capital "M"

    public DbSet<Actor_Movie> Actors_Movies { get; set; }

    public DbSet<Cinema> Cinemas { get; set; }

    public DbSet<Producer> Producers { get; set; }
  }
}
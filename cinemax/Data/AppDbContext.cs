using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cinemax.Models;



namespace cinemax.Data {
  public class AppDbContext:DbContext {

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

    }

    protected override void OnModelCreating(ModelBuillder modelBuillder) {
      modelBuillder.Entity<Actor_Movie>().Haskey(am => new {
        am.ActorId,
        am.MovieId
      });

      modelBuillder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => async.Actors_Movies).HasForeignKey(modelBuillder => m.MovieId);

      modelBuillder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => async.Actors_Movies).HasForeignKey(modelBuillder => m.ActorId);

      base.OnModelCreating(modelBuillder);
    }

    public Obset<Actor> Actors { get; set; }
    
    public Obset<Movies> Movies { get; set; }

    public Obset<Actor_Movie> Actors_Movies { get; set; }

    public Obset<Cinema> Cinemas { get; set; }

    public Obset<Producer> Producers { get; set; }
  }
}
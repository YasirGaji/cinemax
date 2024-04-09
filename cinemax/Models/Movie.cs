using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using cinemax.Data



namespace cinemax.Models {
  public class Movie {

    [key]

    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }

    public string ImageURL { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public MovieCategory MovieCategory { get; set; }

  }
}
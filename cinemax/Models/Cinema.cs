using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace cinemax.Models {
  public class cinema {

    [key]

    public int Id { get; set; }
    public string Logo { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
  }

  // Relationships
  public List<Movie> Movies { get; set; }
  
  
}
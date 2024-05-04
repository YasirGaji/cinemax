using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace cinemax.Models {
  public class Actor {

    [Key]

    public int Id { get; set; }
    public string ProfilePictureURL { get; set; }

    public string FullName { get; set; }

    public string Bio { get; set; }

    // Relationships

    public List<Actor_Movie> Actors_Movies  { get; set; }
    
    
  }
}
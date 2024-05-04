using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace cinemax.Models {
  public class Producer {

    [Key]

    public int Id { get; set; }
    public string ProfilePictureURL { get; set; }

    public string FullName { get; set; }

    public string Bio { get; set; }

    // Relationship

    public List<Movie> Movies { get; set; }
  }
}
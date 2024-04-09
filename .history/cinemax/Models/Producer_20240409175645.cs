using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace cinemax.Models {
  public class Actor {

    [key]

    public int Id { get; set; }
    public string ProfilePictureURL { get; set; }

    public string FullName { get; set; }

    public string Bio { get; set; }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using cinemax.Data;
using System.ComponentModel.DataAnnotations.Schema;



namespace cinemax.Models {
	public class Movie {

		[Key]

		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public string ImageURL { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public MovieCategory MovieCategory { get; set; }

		// Relationships

		public List<Actor_Movie> Actors_Movies { get; set; }
		
		// cinema
		public int CinemaId { get; set; }

		[ForeignKey("CinemaId")]
		
		public Cinema Cinema { get; set; }
		
		// producer
		public int ProducerId { get; set; }

		[ForeignKey("ProducerId")]
		
		public Producer Producer { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Movie
    {
        public Movie()
        {
            this.MovieActors = new HashSet<MovieActor>();
        }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
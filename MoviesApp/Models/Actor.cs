using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Actor
    {
        public Actor()
        {
            this.MovieActors = new HashSet<MovieActor>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
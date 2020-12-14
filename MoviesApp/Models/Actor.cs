using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoviesApp.Models
{
    public class Actor
    {
        public Actor()
        {
            this.MoviesActors = new HashSet<MoviesActors>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<MoviesActors> MoviesActors { get; set; }
    }
}
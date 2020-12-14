using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesApp.Filters;

namespace MoviesApp.Services.Dto
{
   public class ActorDto
    {
        public int? Id { get; set; }

        [Required]
        [CheckName(4)]
        public string Name { get; set; }

        [Required]
        [CheckName(4)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public virtual ICollection<MovieDto> Movies { get; set; }
    }

}

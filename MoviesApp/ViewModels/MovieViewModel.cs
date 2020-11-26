using MoviesApp.Models;
using System;
using System.Collections.Generic;

namespace MoviesApp.ViewModels
{
    public class MovieViewModel:InputMovieViewModel
    {
        public int Id { get; set; }
        public virtual ICollection<MovieActor> Actors { get; set; }
    }
}
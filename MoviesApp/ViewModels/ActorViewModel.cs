using MoviesApp.Models;
using System;
using System.Collections.Generic;

namespace MoviesApp.ViewModels
{
    public class ActorViewModel:InputActorViewModel
    {
        public int Id { get; set; }
        public virtual ICollection<MovieActor> Movies { get; set; }
    }
}
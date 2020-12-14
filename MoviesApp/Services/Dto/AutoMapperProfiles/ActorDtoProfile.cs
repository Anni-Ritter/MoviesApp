using AutoMapper;
using MoviesApp.Models;
using MoviesApp.ViewModels;
using System.Linq;

namespace MoviesApp.Services.Dto.AutoMapperProfiles
{ 
    public class ActorDtoProfile:Profile
    {
        public ActorDtoProfile()
        {
            CreateMap<Actor, ActorDto>()
                 .ForMember(dto => dto.Movies, opt => opt.MapFrom(src => src.MoviesActors
                    .Select(m => new MovieDto
                    {
                        Id = m.MovieId,
                        Title = m.Movie.Title,
                    }).ToList()))
            .ReverseMap();
        }
    }
}

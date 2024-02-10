using AutoMapper;
using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.Feature.Movies.Queries.Responces;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Mapping.Movies
{
    public class MoviesMappingProfile : Profile
    {
        public MoviesMappingProfile()
        {
            CreateMap<Movie, GetMovieResponse>();
            CreateMap<UpdateMovieCommand, GetMovieResponse>();

            CreateMap<AddMovieCommand, Movie>();
            CreateMap<UpdateMovieCommand, Movie>();

        }
    }
}

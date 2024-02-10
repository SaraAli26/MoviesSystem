using FluentValidation;
using MediatR;
using MovieSystem.Application.Base;
using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.Feature.Movies.Queries.Responces;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class UpdateMovieCommand :  IRequest<Response<GetMovieResponse>>
    {
        public int MovieId { get; set; }

        public string Name { get; set; }
        public string Poster { get; set; }

        public string Video { get; set; }

        public bool Type { get; set; }

        public int CategoryId { get; set; }
    }
}
using MediatR;
using MovieSystem.Application.Base;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class AddMovieCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }

        public string Poster { get; set; }

        public string Video { get; set; }

        public bool Type { get; set; }

        public int CategoryId { get; set; }

    }
}

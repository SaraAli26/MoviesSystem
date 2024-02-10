using MovieSystem.Application.Base;
using MovieSystem.Application.Feature.Movies.Queries.Responces;
using MediatR;

namespace MovieSystem.Application.Feature.Movies.Queries.Models
{
    public class GetMovieByIdQuery : IRequest<Response<GetMovieResponse>>
    {
        public int MovieId { get; set; }
    }
}

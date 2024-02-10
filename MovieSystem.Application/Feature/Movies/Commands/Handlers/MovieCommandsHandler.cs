using AutoMapper;
using MovieSystem.Application.Base;
using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.Feature.Movies.Queries.Responces; 
using MovieSystem.Domain.Entities;
using MediatR;
using MovieSystem.Infrastructure.Repositories;
using MovieSystem.Infrastructure.Repositories.MovieRepositories;



namespace MovieSystem.Application.Feature.Movies.Commands.Handlers
{
    public class MovieCommandsHandler : ResponseHandler,
                                       IRequestHandler<AddMovieCommand, Response<string>>,
                                       IRequestHandler<DeleteMovieCommand, Response<string>>,
                                       IRequestHandler<UpdateMovieCommand, Response<GetMovieResponse>>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieCommandsHandler(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<Response<string>> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = _mapper.Map<Movie>(request);
            var result = await _movieRepository.Add(movie);

            if (result is null)
                return BadRequest<string>("Something Went Wrong");

            return Created(" Movie Added Successfully");
        }

        public async Task<Response<string>> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            var result = await _movieRepository.Delete(request.MovieId);

            if (!result)
                return BadRequest<string>("");

            return Deleted<string>("");
        }
        public async Task<Response<GetMovieResponse>> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = _mapper.Map<Movie>(request);

            var result = await _movieRepository.Update(movie);

            var resultDto = _mapper.Map<GetMovieResponse>(request);

            if (resultDto == null) { return BadRequest<GetMovieResponse>(""); }
            else { return Success<GetMovieResponse>(resultDto); }
        }

       

    }
}

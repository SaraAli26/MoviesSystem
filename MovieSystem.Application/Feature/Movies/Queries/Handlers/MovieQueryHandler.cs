using AutoMapper;
using MovieSystem.Application.Base;
using MovieSystem.Application.Feature.Movies.Queries.Models;
using MovieSystem.Application.Feature.Movies.Queries.Responces;
using MovieSystem.Infrastructure.Repositories;
using MediatR;
using MovieSystem.Infrastructure.Repositories.MovieRepositories;

namespace MovieSystem.Application.Feature.Movies.Queries.Handlers
{
    public class MovieQueryHandler : ResponseHandler,
                                     IRequestHandler<GetAllMoviesQuery, Response<IEnumerable<GetMovieResponse>>>,
                                     IRequestHandler<GetMovieByIdQuery, Response<GetMovieResponse>>
    {
        #region CTOR
        private IMovieRepository _movieRepository;
        private IMapper _mapper;

        public MovieQueryHandler(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }
        #endregion

        public async Task<Response<IEnumerable<GetMovieResponse>>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            var moviesList = await _movieRepository.GetAll();
            if (moviesList == null)
            {
                return NotFound<IEnumerable<GetMovieResponse>>();
            }
            else
            {
                var ListMapped = _mapper.Map<IEnumerable<GetMovieResponse>>(moviesList);
                var result = Success(ListMapped);
                result.Meta = new { count = ListMapped.Count() };
                return result;
            }

        }

        public async Task<Response<GetMovieResponse>> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _movieRepository.GetById(request.MovieId);

            if (entity == null)
            {
                return NotFound<GetMovieResponse>("Sorry, There is no data to display!");
            }
            else
            {
                var entityMapped = _mapper.Map<GetMovieResponse>(entity);


                return Success(entityMapped);
            }
        }


    }
    
}

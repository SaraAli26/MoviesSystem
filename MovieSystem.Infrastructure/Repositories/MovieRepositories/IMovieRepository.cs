using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.MovieRepositories
{
    public interface IMovieRepository
    {
        Task<Movie> GetById(int id);
        Task<IEnumerable<Movie>> GetAll();
        Task Add(Movie movie);
        Task Update(Movie movie);
        Task Delete(int id);
        
    }
}

using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.MovieRepositories
{
    
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _dbContext;

        public MovieRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Movie> GetById(int id)
        {
            return await _dbContext.Movies.FindAsync(id);
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _dbContext.Movies.ToListAsync();
        }

        public async Task<Movie> Add(Movie movie)
        {
            _dbContext.Movies.Add(movie);
            await _dbContext.SaveChangesAsync();

            return movie ;
        }

        public async Task<Movie> Update(Movie movie)
        {
            _dbContext.Movies.Update(movie);
            await _dbContext.SaveChangesAsync();

            return movie;
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await _dbContext.Movies.FindAsync(id);
            if (movie != null)
            {
                _dbContext.Movies.Remove(movie);
                await _dbContext.SaveChangesAsync();

           

                return true;
            }

            return false;
        }
    }

}

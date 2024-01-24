using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.UserPaidMovieRepositories
{
    // Infrastructure Layer
    public class UserPaidMovieRepository : IUserPaidMovieRepository
    {
        private readonly MovieDbContext _dbContext;

        public UserPaidMovieRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserPaidMovie> GetById(int id)
        {
            return await _dbContext.UserPaidMovies.FindAsync(id);
        }

        public async Task<IEnumerable<UserPaidMovie>> GetAll()
        {
            return await _dbContext.UserPaidMovies.ToListAsync();
        }

        public async Task Add(UserPaidMovie userPaidMovie)
        {
            _dbContext.UserPaidMovies.Add(userPaidMovie);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(UserPaidMovie userPaidMovie)
        {
            _dbContext.UserPaidMovies.Update(userPaidMovie);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var userPaidMovie = await _dbContext.UserPaidMovies.FindAsync(id);
            if (userPaidMovie != null)
            {
                _dbContext.UserPaidMovies.Remove(userPaidMovie);
                await _dbContext.SaveChangesAsync();
            }
        }
        // Other methods...
    }

}

using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.RatingRepositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly MovieDbContext _dbContext;

        public RatingRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Rating> GetById(int id)
        {
            return await _dbContext.Ratings.FindAsync(id);
        }

        public async Task<IEnumerable<Rating>> GetAll()
        {
            return await _dbContext.Ratings.ToListAsync();
        }

        public async Task Add(Rating rating)
        {
            _dbContext.Ratings.Add(rating);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Rating rating)
        {
            _dbContext.Ratings.Update(rating);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var rating = await _dbContext.Ratings.FindAsync(id);
            if (rating != null)
            {
                _dbContext.Ratings.Remove(rating);
                await _dbContext.SaveChangesAsync();
            }
        }
      
    }

}

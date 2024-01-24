using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.ReviewRepositories
{
    // Infrastructure Layer
    public class ReviewRepository : IReviewRepository
    {
        private readonly MovieDbContext _dbContext;

        public ReviewRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Review> GetById(int id)
        {
            return await _dbContext.Reviews.FindAsync(id);
        }

        public async Task<IEnumerable<Review>> GetAll()
        {
            return await _dbContext.Reviews.ToListAsync();
        }

        public async Task Add(Review review)
        {
            _dbContext.Reviews.Add(review);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Review review)
        {
            _dbContext.Reviews.Update(review);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var review = await _dbContext.Reviews.FindAsync(id);
            if (review != null)
            {
                _dbContext.Reviews.Remove(review);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

}

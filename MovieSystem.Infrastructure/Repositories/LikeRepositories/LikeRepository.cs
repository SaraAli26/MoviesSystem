using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.LikeRepositories
{
    // Infrastructure Layer
    public class LikeRepository : ILikeRepository
    {
        private readonly MovieDbContext _dbContext;

        public LikeRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Like> GetById(int id)
        {
            return await _dbContext.Likes.FindAsync(id);
        }

        public async Task<IEnumerable<Like>> GetAll()
        {
            return await _dbContext.Likes.ToListAsync();
        }

        public async Task Add(Like like)
        {
            _dbContext.Likes.Add(like);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Like like)
        {
            _dbContext.Likes.Update(like);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var like = await _dbContext.Likes.FindAsync(id);
            if (like != null)
            {
                _dbContext.Likes.Remove(like);
                await _dbContext.SaveChangesAsync();
            }
        }
        
    }

}

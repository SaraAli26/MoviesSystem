using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using MovieSystem.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MovieDbContext _dbContext;

        public CategoryRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Category> GetById(int id)
        {
            return await _dbContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task Add(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Category category)
        {
            _dbContext.Categories.Update(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                await _dbContext.SaveChangesAsync();
            }
        }
        
    }

}

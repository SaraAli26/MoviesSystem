using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> GetAll();
        Task Add(Category category);
        Task Update(Category category);
        Task Delete(int id);
       
    }
}

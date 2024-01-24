using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.RatingRepositories
{
    public interface IRatingRepository
    {
        Task<Rating> GetById(int id);
        Task<IEnumerable<Rating>> GetAll();
        Task Add(Rating rating);
        Task Update(Rating rating);
        Task Delete(int id);
        // Other methods...
    }

}

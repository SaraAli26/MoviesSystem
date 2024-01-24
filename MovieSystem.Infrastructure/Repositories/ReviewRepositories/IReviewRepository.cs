using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.ReviewRepositories
{
    public interface IReviewRepository
    {
        Task<Review> GetById(int id);
        Task<IEnumerable<Review>> GetAll();
        Task Add(Review review);
        Task Update(Review review);
        Task Delete(int id);
    }

}

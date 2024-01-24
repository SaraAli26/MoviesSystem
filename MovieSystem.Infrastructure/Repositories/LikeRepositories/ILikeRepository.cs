using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.LikeRepositories
{
    public interface ILikeRepository
    {
        Task<Like> GetById(int id);
        Task<IEnumerable<Like>> GetAll();
        Task Add(Like like);
        Task Update(Like like);
        Task Delete(int id);
    }

}

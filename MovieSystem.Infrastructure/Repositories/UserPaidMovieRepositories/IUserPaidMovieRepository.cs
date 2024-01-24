using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Repositories.UserPaidMovieRepositories
{
    // Infrastructure Layer
    public interface IUserPaidMovieRepository
    {
        Task<UserPaidMovie> GetById(int id);
        Task<IEnumerable<UserPaidMovie>> GetAll();
        Task Add(UserPaidMovie userPaidMovie);
        Task Update(UserPaidMovie userPaidMovie);
        Task Delete(int id);
    }

}

using Microsoft.EntityFrameworkCore;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructure.Database
{
    // Infrastructure Layer
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserPaidMovie> UserPaidMovies { get; set; }


        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
    }

}

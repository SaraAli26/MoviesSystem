using Microsoft.Extensions.DependencyInjection;
using MovieSystem.Infrastructure.Repositories;
using MovieSystem.Infrastructure.Repositories.MovieRepositories;
using MovieSystem.Infrastructure.Repositories.CategoryRepositories;
using MovieSystem.Infrastructure.Repositories.ReviewRepositories;


namespace MovieSystem.Infrastructure
{
    public static class InfrastructureDependencies
    {

        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
         
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();

            return services;
        }
    }
}

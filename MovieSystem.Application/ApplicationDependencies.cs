using FluentValidation;
//using MovieSystem.Application.Behaviors;
using MovieSystem.Infrastructure.Repositories;
//using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MovieSystem.Infrastructure.Repositories.MovieRepositories;
using MediatR;
using MovieSystem.Application.Behaviors;

namespace MovieSystem.Application
{
    public static class ApplicationDependencies
    {
        public static IServiceCollection AddApplicationDependeicies(this IServiceCollection services)
        {
            //repositories
            services.AddTransient<IMovieRepository, MovieRepository>();
           

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;
        }
    }
}

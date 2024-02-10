using FluentValidation;
using MovieSystem.Application.Feature.Movies.Commands.Models;
namespace MovieSystem.Application.Feature.Movies.Commands.Validators
{
    public class DeleteMovieValidator : AbstractValidator<DeleteMovieCommand>
    {
        public DeleteMovieValidator() { ApplyValidationsRules(); }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.MovieId)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Movie Id Required");
        }
    }
}

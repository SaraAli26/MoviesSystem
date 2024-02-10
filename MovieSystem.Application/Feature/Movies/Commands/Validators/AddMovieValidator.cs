using FluentValidation;
using MovieSystem.Application.Feature.Movies.Commands.Models;
namespace MovieSystem.Application.Feature.Movies.Commands.Validators
{
    public class AddMovieValidator : AbstractValidator<AddMovieCommand>
    {
        public AddMovieValidator() { ApplyValidationsRules(); }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Name)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Movie Name Required")
               .MinimumLength(1).WithMessage("Movie Name Minimum Length is 1 characters ")
               .MaximumLength(50).WithMessage("Movie Name Maximum Length is 50 characters ");

            RuleFor(x => x.Poster)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Poster link Required");

            RuleFor(x => x.Video)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Video link is Required");

            RuleFor(x => x.Type)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Movie type Required");

            RuleFor(x => x.CategoryId)
               .NotEmpty().WithMessage("NotEmpty")
               .NotNull().WithMessage("Category Id is Required");

        }
    }
}

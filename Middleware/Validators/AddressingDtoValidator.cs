using Contracts;
using FluentValidation;

namespace Middleware.Validators
{
    public class AddressingDtoValidator : AbstractValidator<AddressingDto>
    {
        public AddressingDtoValidator()
        {
            RuleFor(x => x.District)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.Mr)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.Quarter)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.Street)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.Building)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.Corpus)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.Building)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
            RuleFor(x => x.InstitutionName)
                .NotNull()
                .NotEmpty()
                .Matches("^[a-zA-Z0-9 ]*$");
        }
    }
}

using FluentValidation;

namespace Domain.Dtos.Validations
{
    public class FighterDtoValidator : AbstractValidator<FighterDto>
    {
        public FighterDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30)
                .MinimumLength(8);

            RuleFor(x => x.NickName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(4);

            RuleFor(x => x.Martialarts)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(4);
        }
       
    }
}

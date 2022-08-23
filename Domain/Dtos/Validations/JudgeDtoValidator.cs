using FluentValidation;

namespace Domain.Dtos.Validations
{
    public class JudgeDtoValidator : AbstractValidator<JudgeDto>
    {
        public JudgeDtoValidator()
        {
            RuleFor(x => x.Phone)
                 .NotEmpty();

            RuleFor(x=> x.Name)
                 .NotEmpty()
                .NotNull()
                .MaximumLength(30)
                .MinimumLength(8);
        }
    }
}

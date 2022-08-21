using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Validations
{
    public class CombatDtoValidator : AbstractValidator<CombatDto>
    {
        public CombatDtoValidator()
        {
            //apelidoFirst
            RuleFor(x => x.FistNickName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(4);

                //apelidoSecond
                //rounds
                //status_luta
                //dataluta
        }
    }
}

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
        //classe de validação de dados 
        public CombatDtoValidator()
        {
            //apelidoFirst
            RuleFor(x => x.FistNickName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(4);

            //apelidoSecond
            RuleFor(x => x.SecondNickName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(20)
                .MinimumLength(4);

            //rounds
            RuleFor(x => x.Rounds)
               .NotEqual(0)
               .NotNull();
            
            //status_luta
            //validação criado pela regra de negócio 
            
            //dataluta
            //validação criado pela regra de negócio
        }
    }
}

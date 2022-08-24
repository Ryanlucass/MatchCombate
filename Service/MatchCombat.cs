using Domain.Intefaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Data.Repository;
using Domain.Results;
using Domain.Dtos;
using AutoMapper;
using Domain.Dtos.Validations;

namespace Service
{
    public class MatchCombat : IMatchCombat
    {
        private readonly ICombatRepository _combatRepository;
        private readonly IMapper _mapper;  

        public MatchCombat(ICombatRepository combatRepository, IMapper mapper)
        {
            _combatRepository = combatRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<CombatDto>> CreateAsyncCombat(CombatDto combatDto)
        {
            if (combatDto == null)
                return ResultService.Fail<CombatDto>("Objeto está nulo");

            var result = new CombatDtoValidator().Validate(combatDto);
            if (!result.IsValid)
                return ResultService.RequestError<CombatDto>("Problema na validação",result);

            var combat = _mapper.Map<Combat>(combatDto);
            var data = await _combatRepository.CreateAsync(combat);

            //return ResultService.Ok<CombatDto>(_mapper.Map<CombatDto>(data)); 
            ResultService<CombatDto> resultService = new();
           return resultService.Ok<(_mapper.Map<CombatDto>(data));
        }

        public Task<bool> DeleteAsyncCombat(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultService<CombatDto>> UpdateAsyncCombat(CombatDto combat)
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using Data.Interfaces;
using Domain.Dtos;
using Domain.Dtos.Validations;
using Domain.Intefaces;
using Domain.Model;
using Domain.Results;
using System;
using System.Threading.Tasks;

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
                return ResultService.RequestError<CombatDto>("Problema na validação", result);

            var combatEntities = _mapper.Map<Combat>(combatDto);
            var data = await _combatRepository.CreateAsync(combatEntities);

            return (ResultService<CombatDto>)ResultService.Ok(_mapper.Map<CombatDto>(data));
        }

        public async Task<ResultService<CombatDto>> DeleteAsyncCombat(int id)
        {
            var resultId = await _combatRepository.GetByIdAsync(id);

            if (resultId != null)
                return ResultService<CombatDto>.Fail<CombatDto>("Id não existe");

            var resultDelete = await _combatRepository.DeleteAsync(id);
            
            if(resultId != null)
                return ResultService<CombatDto>.Fail<CombatDto>("Erro ao deletar combate");

            return (ResultService<CombatDto>)ResultService.Ok<CombatDto>(true);
        }

        public async Task<ResultService<CombatDto>> UpdateAsyncCombat(CombatDto combatDto)
        {
            if (combatDto == null)
                return ResultService.Fail<CombatDto>("Objeto está nulo");

            var result = new CombatDtoValidator().Validate(combatDto);
            if (!result.IsValid)
                return ResultService.RequestError<CombatDto>("Problema na validação", result);

            var combatEntities = _mapper.Map<Combat>(combatDto);
            var data = await _combatRepository.UpdateAsync(combatEntities);

            return (ResultService<CombatDto>)ResultService.Ok(_mapper.Map<CombatDto>(data));
        }
    }
}

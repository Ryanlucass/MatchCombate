using AutoMapper;
using Domain.Dtos.FighterDtos;
using Domain.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service
{
    public class MatchCombat : IMatchCombat
    {
        private readonly IFighterRepository _fighterRepository;
        private readonly IMapper _mapper;
        public MatchCombat(IFighterRepository repository, IMapper mapper)
        {
            _fighterRepository = repository;
            _mapper = mapper;
        }

        public async Task<FighterDtoGet> CreateFighter(FighterDto item)
        {
            Fighter fighter = _mapper.Map<Fighter>(item);
            Fighter resultFighter = await _fighterRepository.CreateAsync(fighter);

            return _mapper.Map<FighterDtoGet>(resultFighter);
        }

        public async Task<List<FighterDtoGet>> SelectFighter( int? weightClass)
        { 
            List<Fighter> listFight = await _fighterRepository.GetFighteraAsync();
            return weightClass >= 44.35 ?
                listFight.Where(x => x.WeightClass == weightClass).Select(x => _mapper.Map<FighterDtoGet>(x)).ToList() :
                listFight.Select(x => _mapper.Map<FighterDtoGet>(x)).ToList();
        }

        public async Task<FighterDtoGet> SelectFighterById(int id)
        {
            var result = await _fighterRepository.GetByIdAsync(id);
            return _mapper.Map<FighterDtoGet>(result);
        }

        public async Task<FighterDtoGet> UpdateFighter(FighterDto fighterDto, int id)
        {
            var fightExist = _fighterRepository.GetByIdAsync(id).Result;
            if (fightExist == null){throw new Exception($"Id: {id} não existe");}

            //update do item
            fightExist.Name = fighterDto.Name ?? fightExist.Name;
            fightExist.Cpf = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.NickName = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.WeightClass = fighterDto.WeightClass != 0 ? fighterDto.WeightClass : fightExist.WeightClass;
            fightExist.FightId = fighterDto.FightId != null ? fighterDto.FightId : fightExist.FightId;
            fightExist.CreateAt = fighterDto.CreateAt != DateTime.MinValue ? fighterDto.CreateAt.Date : fightExist.CreateAt;

            var fighterUpdate = await _fighterRepository.UpdateAsync(fightExist);
            return _mapper.Map<FighterDtoGet>(fighterUpdate);
        }

        public async Task<bool> DeleteFighter(int id) => await _fighterRepository.DeleteAsync(id);

    }
}

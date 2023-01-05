using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Fighters
using Domain.Dtos.FighterDtos;
using Data.Repository;

namespace Service
{
    public class FightService : IFightService
    {
        private readonly IMapper _mapper;
        private readonly IFightRepository _fightRepository;
        public FightService(IFightRepository fightRepository,IMapper mapper)
        {
            _fightRepository = fightRepository;
            _mapper = mapper;
        }
        public async Task<FightDtoGet> CreateFight(FightDto item)
        {
            Fight entitiesFight = _mapper.Map<Fight>(item);
            Fight resultFight = await _fightRepository.CreateAsync(entitiesFight);
            return _mapper.Map<FightDtoGet>(resultFight);
        }

        public async Task<List<FightDtoGet>> SelectAllFight(DateTime? date)
        {
            List<Fight> listFight = await _fightRepository.GetFightsAsync();

            return date == null || date == DateTime.MinValue ?
                listFight.Select(x => _mapper.Map<FightDtoGet>(x)).ToList() :
                listFight.Where(x => x.Date == date).Select(x => _mapper.Map<FightDtoGet>(x)).ToList();
        }
        public async Task<FightDtoGet> SelectFight(int id) 
        {
            var fightResult = await _fightRepository.GetByIdAsync(id);
            return _mapper.Map<FightDtoGet>(fightResult);
        }
        public async Task<FightDtoGet> UpdateFight(FightDtoPatch fighterDto, int id)
        {
            var fightExist = _fightRepository.GetByIdAsync(id).Result;
            if(fightExist == null) {throw new Exception($"Id: {id} não existe");}

            fightExist.Locale = fighterDto.Locale ?? fightExist.Locale;
            fightExist.Box = fighterDto.Box ?? fightExist.Box;
            fightExist.Date = fighterDto.Date != DateTime.MinValue ? fighterDto.Date : fightExist.Date;
 
            var fightUpdate = await _fightRepository.UpdateAsync(fightExist);
            return _mapper.Map<FightDtoGet>(fightUpdate);

        }
        public async Task<bool> DeleteFight(int id) => await _fightRepository.DeleteAsync(id);
    }
}
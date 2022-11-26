using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service
{
    public class FightService : IFightService
    {
        private readonly IMapper _mapper;
        private readonly IFightRepository _fightRepository;
        public FightService(IFightRepository fightRepository, IMapper mapper)
        {
            _fightRepository = fightRepository;
            _mapper = mapper;
        }
        public async Task<FightDtoGet> CreateFight(FightDto obj)
        {
            Fight interfaceFight = _mapper.Map<Fight>(obj);
            Fight fightResult = await _fightRepository.CreateAsync(interfaceFight);
            return _mapper.Map<FightDtoGet>(fightResult);
        }
        public async Task<bool> DeleteFight(int id)
        {
            if (id == 0) return false;
            Fight fightResult = await _fightRepository.GetByIdAsync(id);
       
            return fightResult != null ? await _fightRepository.DeleteAsync(fightResult.Id) : false;
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
            if(fightResult == null) { throw new Exception($"Id não existe na base de dados: {id}"); }
            return _mapper.Map<FightDtoGet>(fightResult);
        }
        public async Task<FightDtoGet> UpdateFight(FightDtoPut fighterDto, int id)
        {
            var fightExist = _fightRepository.GetByIdAsync(id).Result;
            if(fightExist == null) {throw new Exception($"Id: {id} não existe");}

            //update item
            fightExist.Locale = fighterDto.Locale ?? fightExist.Locale;
            fightExist.Box = fightExist.Box ?? fightExist.Box;
            fightExist.Date = fighterDto.Date != DateTime.MinValue ? fighterDto.Date : fightExist.Date;
 
            var fightUpdate = await _fightRepository.UpdateAsync(fightExist);
            return _mapper.Map<FightDtoGet>(fightUpdate);

        }
    }
}
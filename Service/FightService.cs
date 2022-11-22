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

        public async Task<FightDto> CreateFight(FightDto obj)
        {
            Fight interfaceFight = _mapper.Map<Fight>(obj);
            Fight fightResult = await _fightRepository.CreateAsync(interfaceFight);
            return _mapper.Map<FightDto>(fightResult);
        }

        public Task<bool> DeleteFight(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<FightDto>> SelectAllFight(DateTime? date)
        {
            List<Fight> listFight = await _fightRepository.GetFightsAsync();

            return date == null || date == DateTime.MinValue ?
                listFight.Select(x => _mapper.Map<FightDto>(x)).ToList() :
                listFight.Where(x => x.Date == date).Select(x => _mapper.Map<FightDto>(x)).ToList();
        }

        public async Task<FightDto> SelectFight(int id)
        {
            var fightResult = await _fightRepository.GetByIdAsync(id);
            return _mapper.Map<FightDto>(fightResult);
        }

        public async Task<FightDto> UpdateFight(FightDto fighterDto)
        {

            var fightExist = _fightRepository.GetByIdAsync((int)fighterDto.Id).Result;
            
            if(fightExist == null)
            {
                throw new Exception($"Id: {fighterDto.Id} não existe");
            }

            //update item
            fightExist.Locale = fighterDto.Locale ?? fightExist.Locale;
            fightExist.Box = fightExist.Box ?? fightExist.Box;
            fightExist.Date = fighterDto.Date != DateTime.MinValue ? fighterDto.Date : fightExist.Date;
 
            var fightUpdate = await _fightRepository.UpdateAsync(fightExist);

            return _mapper.Map<FightDto>(fightUpdate);

        }
    }
}

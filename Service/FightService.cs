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
        private readonly IFightRepository _fightRepository;

        public FightService(IFightRepository fightRepository)
        {
            _fightRepository = fightRepository;
        }

        public async Task<FightDto> CreateFight(FightDto fight)
        {
            //TODO use mapper 
            var fightData = new Fight()
            {
              Date = fight.Data,
              Locale = fight.Local,
              Box = fight.Octogono
            };

            var result = await _fightRepository.CreateAsync(fightData);
            return fight;
        }

        public Task<bool> DeleteFight(int id)
        {
            //TODO Ajeitar cascata do delete
            throw new NotImplementedException();
        }
        /// <summary>
        /// Query retorna as lutas referentes a data de hoje
        /// </summary>
        /// <param name="dates"></param>
        /// <returns></returns>
        public async Task<List<FightDto>> SelectAllFight(DateTime? dates)
        {
            var result = await _fightRepository.GetFightsAsync();            

            if(dates == null || dates == DateTime.MinValue)
            {
                var listFightsDto = result.Select(x =>
                     new FightDto()
                     {
                         Id = x.Id,
                         Data = x.Date,
                         Local = x.Locale,
                         Octogono = x.Box
                     }).ToList();

                return listFightsDto; 
            }

            var listFifhtsToday = result.Where(x => x.Date == DateTime.Today).Select(x => 
                new FightDto()
                {
                    Id = x.Id,
                    Data = x.Date,
                    Local = x.Locale,
                    Octogono = x.Box
                }).ToList();

            return listFifhtsToday;
        }

        public async Task<FightDto> SelectFight(int id)
        {
            var dataFight = await _fightRepository.GetByIdAsync(id);

            return new FightDto()
            {
                Id = dataFight.Id,
                Data = dataFight.Date,
                Octogono = dataFight.Locale,
                Local = dataFight.Locale
            };
        }

        public async Task<FightDto> UpdateFight(FightDto fighterDto)
        {

            var fightExist = _fightRepository.GetByIdAsync((int)fighterDto.Id).Result;
            
            if(fightExist == null)
            {
                throw new Exception($"Id: {fighterDto.Id} não existe");
            }

            //update item
            fightExist.Locale = fighterDto.Local ?? fightExist.Locale;
            fightExist.Box = fightExist.Box ?? fightExist.Box;
            fightExist.Date = fighterDto.Data != DateTime.MinValue ? fighterDto.Data : fightExist.Date;
 
            var fightUpdate = await _fightRepository.UpdateAsync(fightExist);

            if (fightUpdate != null)
            {
                fighterDto.Id = fightUpdate.Id;
                fighterDto.Data = fightUpdate.Date;
                fighterDto.Local = fightUpdate.Locale;
                fighterDto.Octogono = fightUpdate.Box;
            
                return fighterDto;
            }
            else { return null; }
        }
    }
}

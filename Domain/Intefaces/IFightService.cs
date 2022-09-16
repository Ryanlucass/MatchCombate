using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFightService
    {
        public Task<FightDto> CreateFight(FightDto fight);
        public Task<FightDto> UpdateFight(FightDto fighterDto);
        public Task<List<FightDto>> SelectAllFight(DateTime? dates);
        public Task<FightDto> SelectFight(int id);
        public Task<bool> DeleteFight(int id);
    }
}
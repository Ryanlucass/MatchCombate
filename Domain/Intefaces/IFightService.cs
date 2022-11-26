using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFightService
    {
        public Task<FightDtoGet> CreateFight(FightDto fight);
        public Task<FightDtoGet> UpdateFight(FightDtoPut fighterDto, int id);
        public Task<List<FightDtoGet>> SelectAllFight(DateTime? dates);
        public Task<FightDtoGet> SelectFight(int id);
        public Task<bool> DeleteFight(int id);
    }
}
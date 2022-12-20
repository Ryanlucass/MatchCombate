using Domain.Dtos.FighterDtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMatchCombat
    {
        public Task<FighterDtoGet> CreateFighter(FighterDto fighterDto);
        public Task<List<FighterDtoGet>> SelectFighter(int? weightClass);
        public Task<FighterDtoGet> UpdateFighter(FighterDtoPatch fighterDto, int id);
        public Task<FighterDtoGet> SelectFighterById(int id);
        public Task<bool> DeleteFighter(int id);
        
    }
}
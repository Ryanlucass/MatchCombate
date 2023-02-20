using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMatchCombat
    {
        public Task<FighterResult> CreateFighter(FighterCreate fighterDto);
        public Task<List<FighterResult>> SelectFighter(int? weightClass);
        public Task<FighterResult> UpdateFighter(FighterDtoPatch fighterDto, Guid id);
        public Task<FighterResult> SelectFighterById(Guid id);
        public Task<bool> DeleteFighter(Guid id);
        
    }
}
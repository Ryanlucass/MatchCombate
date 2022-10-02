﻿using Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMatchCombat
    {
        public Task<FighterDto> CreateFighter(FighterDto fighterDto);
        public Task<List<FighterDto>> SelectFighter(int? weightClass);
        public Task<FighterDto> UpdateFighter(FighterDto fighterDto);
        public Task<FighterDto> SelectFighterById(int id);
        public Task<bool> DeleteFighter(int id);
        
    }
}
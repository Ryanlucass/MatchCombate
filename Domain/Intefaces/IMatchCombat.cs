using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMatchCombat
    {
        public Task<FighterDto> CreateFighter(FighterDto fighterDto);
        public Task<List<FighterDto>> SelectFighter(int? weightClass);
        
    }
}
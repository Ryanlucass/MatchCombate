using Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Domain.Interfaces
{
    public interface IFighterRepository
    {
        Task<Fighter> CreateAsync(Fighter fighter);
        Task<Fighter> UpdateAsync(Fighter fighter);
        Task<bool> DeleteAsync(Guid id);
        Task<Fighter> GetByIdAsync(Guid id);
        Task<List<Fighter>> GetFighteraAsync();
    }
}


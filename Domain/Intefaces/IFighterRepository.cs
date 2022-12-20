using Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Domain.Interfaces
{
    public interface IFighterRepository
    {
        Task<Fighter> CreateAsync(Fighter judge);
        Task<Fighter> UpdateAsync(Fighter item);
        Task<bool> DeleteAsync(int id);
        Task<Fighter> GetByIdAsync(int id);
        Task<List<Fighter>> GetFighteraAsync();
    }
}

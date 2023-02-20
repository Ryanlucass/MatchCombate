using Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Domain.Interfaces
{
    public interface IFightRepository
    {
        Task<Fight> CreateAsync(Fight judge);
        Task<Fight> UpdateAsync(Fight item);
        Task<bool> DeleteAsync(Guid id);
        Task<Fight> GetByIdAsync(Guid id);
        Task<List<Fight>> GetFightsAsync();
    }
}

using Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Domain.Interfaces
{
    public interface IFightRepository
    {
        Task<Fight> CreateAsync(Fight judge);
        Task<Fight> UpdateAsync(Fight item);
        Task<bool> DeleteAsync(int id);
        Task<Fight> GetByIdAsync(int id);
        Task<List<Fight>> GetFightsAsync();
    }
}

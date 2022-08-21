using Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ICombatRepository
    {
        Task<Combat> CreateAsync(Combat combat);
        Task<Combat> UpdateAsync(Combat combat);
        Task<bool> DeleteAsync(int id);
        Task<Combat> GetByIdAsync(int id);
        Task<List<Combat>> GetJudgeAsync();

    }
}

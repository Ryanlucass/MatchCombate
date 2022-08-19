using Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IJudgeRepository
    {
        Task<Judge> CreateAsync(Judge judge);
        Task<Judge> UpdateAsync(Judge item);
        Task<bool> DeleteAsync(int id);
        Task<Judge> GetByIdAsync(int id);
        Task<List<Judge>> GetJudgeAsync();
    }
}

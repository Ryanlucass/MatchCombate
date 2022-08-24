using Domain.Dtos;
using Domain.Model;
using Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Intefaces
{
    public interface IMatchCombat
    {
       Task<ResultService<CombatDto>> CreateAsyncCombat(CombatDto combat);
       Task<ResultService<CombatDto>> UpdateAsyncCombat(CombatDto combat);
       Task<bool> DeleteAsyncCombat(int id);
    }
}

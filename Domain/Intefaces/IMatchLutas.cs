using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Intefaces
{
    public interface IMatchLutas
    {
        public bool MatchFight(List<Fighter> lutadores);
        public bool CancelFight();
        public Task<Fighter> CreateLutador(Fighter lutador);
    }
}

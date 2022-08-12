using Domain.Intefaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using Data.Repository;

namespace Service
{
    public class MatchLutas : IMatchLutas
    {

        public MatchLutas(LutadorRepository repository)
        {
            Repository = repository;
        }
        public LutadorRepository Repository { get; set; }

        public bool CancelFight()
        {
            throw new NotImplementedException();
        }

        public bool MatchFight(List<Lutador> lutadores)
        {
            throw new NotImplementedException();
        }
    }
}

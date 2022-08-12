using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ILutadorRepository
    {
        public Lutador CreateLutador();
        public List<Lutador> GetLutadores();
        public Lutador UpdateLutador();
        public bool DeleteLutador();
    }
}

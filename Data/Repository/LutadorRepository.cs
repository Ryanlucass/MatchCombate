using Data.DbCotext;
using Data.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class LutadorRepository : ILutadorRepository
    {

        public LutadorRepository(AplicationContext context)
        {
            _db = context;
        }

        private AplicationContext _db { get; set; }



        public Lutador CreateLutador()
        {
            throw new NotImplementedException();
        }

        public bool DeleteLutador()
        {
            throw new NotImplementedException();
        }

        public List<Lutador> GetLutadores()
        {
            throw new NotImplementedException();
        }

        public Lutador UpdateLutador()
        {
            throw new NotImplementedException();
        }
    }
}

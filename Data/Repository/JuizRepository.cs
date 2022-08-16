using Data.DbCotext;
using Data.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class JuizRepository : IRepository<Juiz>
    {
        public JuizRepository(AplicationContext context)
        {
            _db = context;
        }

        protected readonly AplicationContext _db;


        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Juiz> Insert(Juiz item)
        {
            throw new NotImplementedException();
        }

        public Task<Juiz> select(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Juiz>> Select()
        {
            throw new NotImplementedException();
        }

        public Task<Juiz> Update(Juiz item)
        {
            throw new NotImplementedException();
        }
    }
}
 
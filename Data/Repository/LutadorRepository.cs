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
    public class LutadorRepository : IRepository<Fighter>
    {

        public LutadorRepository(AplicationContext context)
        {
            _db = context;
        }

        protected readonly AplicationContext _db;

        public async Task<Fighter> Insert(Fighter item)
        {
            try
            {
                Fighter lutador = new()
                {
                    Nome = item.Nome,
                    Apelido = item.Apelido,
                    ArteMarcial = item.ArteMarcial,
                    Categoria = item.Categoria,
                    Cpf = item.Cpf,
                    Criadoem = DateTime.Now,
                    GrauArtemarcial = item.GrauArtemarcial ?? null
                };

                _db.Lutadores.Add(lutador);
                
                await _db.SaveChangesAsync();
            }

            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }

            return item;
        }

        public Task<Fighter> Update(Fighter item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Fighter> select(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fighter>> Select()
        {
            throw new NotImplementedException();
        }
    }
}
 
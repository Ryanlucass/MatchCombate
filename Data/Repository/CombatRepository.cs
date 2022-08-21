using Data.DbCotext;
using Data.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CombatRepository : ICombatRepository
    {
        private readonly MatchCombateContext _db;

        public CombatRepository(MatchCombateContext context)
        {
            _db = context;
        }

        public async Task<Combat> CreateAsync(Combat combat)
        {
            try
            {
                _db.Add(combat);
                 await _db.SaveChangesAsync();
                return combat;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Adicionar um Combate",ex);
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                Combat itemforDelete = await GetByIdAsync(id);
                _db.Remove(itemforDelete);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Cancelar Combat ", ex);
            }
        }

        public async Task<Combat> GetByIdAsync(int id) => await _db.Combats.FirstOrDefaultAsync(x => x.Id == id, default);
        

        public async Task<List<Combat>> GetJudgeAsync() => await _db.Combats.ToListAsync<Combat>();


        public async Task<Combat> UpdateAsync(Combat combat)
        {
            try
            {
                _db.Update(combat);
                await _db.SaveChangesAsync();
                return combat;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar combat", ex);
            }
        }
    }
}
 
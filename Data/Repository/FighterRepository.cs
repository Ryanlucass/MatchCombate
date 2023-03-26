using Data.DbCotext;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FighterRepository : IFighterRepository
    {
        private readonly MatchCombateContext _db;

        public FighterRepository(MatchCombateContext db) => _db = db;

        public async Task<Fighter> CreateAsync(Fighter item)
        {
            try
            {
                _db.Add(item);
                await _db.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema ao criar {item.Uid}", ex);
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var fighter = await GetByIdAsync(id);
                if(fighter == null ) { return false;}
                _db.Remove(fighter);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Problema ao deletar {id}",ex);
            }
        }

        public Task<Fighter> GetByCodeIdAsync(string codeId) => _db.Fighters.FirstOrDefaultAsync(x => x.CodeId == codeId);

        public async Task<Fighter> GetByIdAsync(Guid id) => _db.Fighters.FirstOrDefault(x => x.Uid == id);
        
        public async Task<List<Fighter>> GetFighteraAsync(int skip, int take)
        {
            var count = await _db.Fighters.CountAsync();
            var fighters = await _db
                .Fighters
                .AsNoTracking()
                .Skip(skip)
                .Take(take)
                .ToListAsync();
            return fighters;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item">fighter to update</param>
        /// <returns>fighter was update</returns>
        /// <exception cref="Exception"></exception>
        public async Task<Fighter> UpdateAsync(Fighter item)
        {
            try
            {
                _db.Update(item);
                await _db.SaveChangesAsync();

                return GetByIdAsync(item.Uid).Result;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível atualizar o obj", ex);
            }
        }
    }
}
 
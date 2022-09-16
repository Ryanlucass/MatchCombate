using Data.DbCotext;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FighterRepository : IFighterRepository
    {
        private readonly MatchCombateContext _db;

        public FighterRepository(MatchCombateContext db)
        {
            _db = db;
        }
        public async Task<Fighter> CreateAsync(Fighter judge)
        {
            try
            {
                _db.Add(judge);
                await _db.SaveChangesAsync();
                return judge;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema ao criar {judge.Id}", ex);
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var fighter = await GetByIdAsync(id);
                _db.Remove(fighter);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Problema ao deletar {id}",ex);
            }
        }

        public async Task<Fighter> GetByIdAsync(int id) => _db.Fighters.FirstOrDefault(x => x.Id == id);
        
        public async Task<List<Fighter>> GetFighteraAsync() => await _db.Fighters.ToListAsync<Fighter>();
 
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
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Não poi possível atualiar o obj", ex);
            }
        }
    }
}
 
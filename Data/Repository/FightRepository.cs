using Data.DbCotext;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FightRepository : IFightRepository
    {
        private readonly MatchCombateContext _db;

        public FightRepository(MatchCombateContext db)
        {
            _db = db;
        }

        public async Task<Fight> CreateAsync(Fight fight)
        {
            try
            {
                _db.Add(fight);
                await _db.SaveChangesAsync();
                return fight;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema ao criar {fight.Id}", ex);
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                //TODO Ajeitar o delete em cascate
                var fight = await GetByIdAsync(id);
                _db.Remove(fight);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema ao deletar {id}",ex);
            }
        }

        public async Task<Fight> GetByIdAsync(int id) => await _db.Fight.FirstOrDefaultAsync(x => x.Id == id);


        public async Task<List<Fight>> GetFightsAsync() => await _db.Fight.ToListAsync<Fight>();

        public async Task<Fight> UpdateAsync(Fight item)
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
 
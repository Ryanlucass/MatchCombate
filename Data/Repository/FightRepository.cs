using Data.DbCotext;
using Domain.Exptions;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FightRepository : IFightRepository
    {
        private readonly MatchCombateContext _db;
        public FightRepository(MatchCombateContext db)  => _db = db;

        public async Task<Fight> CreateAsync(Fight fight)
        {
            try
            {
                _db.Add(fight);
                await _db.SaveChangesAsync();
                return await GetByIdAsync(fight.Uid);
            }
            catch (Exception ex)
            {
                throw new DbExecption("Fight_Create", $"Erro ao criar item :{ex.Message}");
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                //TODO consertar delete [erro cascate]
                var fight = await GetByIdAsync(id);
                if(fight == null) { return false;}
                _db.Remove(fight);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new DbExecption($"Fight_Delete", $"Erro ao Deletar :{ex.Message}");
            }
        }

        public async Task<Fight> GetByIdAsync(Guid id) {
            await _db.Fighters.ToListAsync<Fighter>();
            return await _db.Fight.FirstOrDefaultAsync(x => x.Uid == id);
        } 
            
        public async Task<List<Fight>> GetFightsAsync()
        {
            await _db.Fighters.ToListAsync<Fighter>();
            return await _db.Fight.ToListAsync<Fight>();
        } 

        public async Task<Fight> UpdateAsync(Fight item)
        {
            try
            {
                _db.Update(item);
                await _db.SaveChangesAsync();
                return GetByIdAsync(item.Uid).Result;
            }
            catch (Exception ex)
            {
                throw new DbExecption($"Fight_Update", $"Erro ao Atualizar :{ex.Message}");
            }
        }
    }
}
 
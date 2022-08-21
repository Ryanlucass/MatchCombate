﻿using Data.DbCotext;
using Data.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                var fighter = GetByIdAsync(id);
                _db.Remove(fighter);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Problema ao deletar {id}",ex);
            }
        }

        public async Task<Fighter> GetByIdAsync(int id) => await _db.Fighters.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<Fighter>> GetJudgeAsync() => await _db.Fighters.ToListAsync<Fighter>();
 
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
 
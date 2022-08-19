using Data.DbCotext;
using Data.Interfaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class JudgeRepository : IJudgeRepository
    {
        private readonly MatchCombateContext _db;
        public JudgeRepository(MatchCombateContext db)
        {
            _db = db;
        }
        public async Task<Judge> CreateAsync(Judge judge)
        {
            try
            {
                _db.Add(judge);
                await _db.SaveChangesAsync();
                return judge;
            }
            catch(Exception ex)
            {
                throw new Exception("Não poi possível criar", ex);
            }
        }
        public async Task<Judge> GetByIdAsync(int id) => await _db.Judges.FirstOrDefaultAsync(j => j.Id == id, default);

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var judgeid = GetByIdAsync(id);
                _db.Remove(judgeid);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao Cancelar {id}",ex);
            }
        }

        public async Task<List<Judge>> GetJudgeAsync() => await _db.Judges.ToListAsync<Judge>();

        public async Task<Judge> UpdateAsync(Judge judge)
        {

            try
            {
                _db.Update(judge);
                await _db.SaveChangesAsync();
                return judge;
            }
            catch (Exception ex)
            {
                throw new Exception("Não poi possível atualiar o obj", ex);
            }


        }
    }
}
 
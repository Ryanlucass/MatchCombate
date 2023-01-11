using Data.DbCotext;
using Domain.Entities;
using Domain.Exptions;
using Domain.Intefaces;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MatchCombateContext _db;
        public UserRepository(MatchCombateContext db) => _db = db;

        public async Task<User> CreateAsync(User user)
        {
            try
            {
                _db.Add(user);
                await _db.SaveChangesAsync();
                return await GetByIdAsync(user.Id);

            }catch(Exception ex)
            {
                throw new DbExecption("User_Create", $"Erro ao criar item :{ex.Message}");
            }
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByIdAsync(Guid id) => await _db.User.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<User>> GetUseraAsync() => await _db.User.ToListAsync<User>();

        public Task<User> UpdateAsync(User item)
        {
            throw new NotImplementedException();
        }
    }
}

using Domain.Entities;
using Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<User> CreateAsync(User judge)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUseraAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User item)
        {
            throw new NotImplementedException();
        }
    }
}

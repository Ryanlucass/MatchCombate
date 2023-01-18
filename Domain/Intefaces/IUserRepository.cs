using Domain.Entities;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Intefaces
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User judge);
        Task<User> UpdateAsync(User item);
        Task<bool> DeleteAsync(Guid id);
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByEmailAsync(string email);
        Task<List<User>> GetUseraAsync();
    }
}

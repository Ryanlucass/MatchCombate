using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Intefaces
{
    public interface IUserService
    {
        Task<UserDto> CreateAsync(UserDto user);
        Task<UserDto> UpdateAsync(Guid id, UserDtoPatch user);
        Task<bool> DeleteAsync(Guid id);
        Task<UserDto> GetByIdAsync(Guid id);
        Task<UserDto> GetByEmailAsync(string email);
        Task<List<UserDto>> GetUserAsync();
    }
}

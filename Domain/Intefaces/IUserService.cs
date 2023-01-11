using Domain.Dtos.UsersDtos;
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
        Task<UserDtoGet> CreateAsync(UserDto user);
        Task<UserDtoGet> UpdateAsync(Guid id, UserDtoPatch user);
        Task<bool> DeleteAsync(Guid id);
        Task<UserDtoGet> GetByIdAsync(Guid id);
        Task<List<UserDtoGet>> GetUseraAsync();
    }
}

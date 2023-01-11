using Domain.Dtos.UsersDtos;
using Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) => _userRepository = userRepository;
      
        public Task<UserDtoGet> CreateAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDtoGet> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDtoGet>> GetUseraAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDtoGet> UpdateAsync(Guid id, UserDtoPatch user)
        {
            throw new NotImplementedException();
        }
    }
}

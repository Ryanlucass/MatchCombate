using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDtoGet> CreateAsync(UserDto user)
        {
            var entititiesUser = _mapper.Map<User>(user);
            var resultUser = await _userRepository.CreateAsync(entititiesUser);
            return _mapper.Map<UserDtoGet>(resultUser);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDtoGet> GetByEmailAsync(string email) => _mapper.Map<UserDtoGet>(await _userRepository.GetByEmailAsync(email));

        public async Task<UserDtoGet> GetByIdAsync(Guid id) => _mapper.Map<UserDtoGet>(await _userRepository.GetByIdAsync(id));
        public async Task<List<UserDtoGet>> GetUserAsync()
        {
            var listUser = await _userRepository.GetUseraAsync();
            return listUser.Select(x => _mapper.Map<UserDtoGet>(x)).ToList();
        }

        public Task<UserDtoGet> UpdateAsync(Guid id, UserDtoPatch user)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public async Task<UserDto> CreateAsync(UserDto user)
        {
            var entititiesUser = _mapper.Map<User>(user);
            var resultUser = await _userRepository.CreateAsync(entititiesUser);
            return _mapper.Map<UserDto>(resultUser);
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetByEmailAsync(string email) => _mapper.Map<UserDto>(await _userRepository.GetByEmailAsync(email));

        public async Task<UserDto> GetByIdAsync(Guid id) => _mapper.Map<UserDto>(await _userRepository.GetByIdAsync(id));
        public async Task<List<UserDto>> GetUserAsync()
        {
            var listUser = await _userRepository.GetUseraAsync();
            return listUser.Select(x => _mapper.Map<UserDto>(x)).ToList();
        }

        public Task<UserDto> UpdateAsync(Guid id, UserDtoPatch user)
        {
            throw new NotImplementedException();
        }
    }
}

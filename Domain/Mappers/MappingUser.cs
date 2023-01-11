using AutoMapper;
using Domain.Dtos.UsersDtos;
using Domain.Entities;

namespace Domain.Mappers
{
    public class MappingToUser : Profile
    {
        public MappingToUser()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDtoGet>()
            .ReverseMap();
        }
    }
}

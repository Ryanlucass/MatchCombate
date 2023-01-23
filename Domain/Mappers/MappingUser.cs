using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Mappers
{
    public class MappingToUser : Profile
    {
        public MappingToUser()
        {
            CreateMap<User, UserDtoGet>()
            .ReverseMap();
            CreateMap<User, UserDto>()
            .ReverseMap();
        }
    }
}

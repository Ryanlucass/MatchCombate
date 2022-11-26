using AutoMapper;
using Domain.Dtos;
using Domain.Model;

namespace Domain.Mappers
{
    public class MappintToFightDto : Profile
    {
        public MappintToFightDto()
        {
            CreateMap<Fight, FightDto>();
            CreateMap<Fight, FightDtoGet>();
        }
    }
    
}

using AutoMapper;
using Domain.Dtos;
using Domain.Model;

namespace Domain.Mappers.Fights
{
    public class MappintToFightDto : Profile
    {
        public MappintToFightDto()
        {
            CreateMap<Fight, FightDtoGet>()
            .ForMember(x=> x.Fights, map =>
            map.MapFrom(x=> x.Fighters));
        }
    }

}

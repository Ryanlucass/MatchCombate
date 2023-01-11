using AutoMapper;
using Domain.Dtos;
using Domain.Model;

namespace Domain.Mappers
{
    public class MappingFight : Profile
    {
        public MappingFight()
        {
            //FightDto => Fight
            CreateMap<FightDto, Fight>()
            .ForMember(x => x.Date, map =>
            map.MapFrom(x => x.Date.ToString("dddd, dd MMMM yyyy HH:mm")))
            .ReverseMap();

            //Fight => FightDtoGet
            CreateMap<Fight, FightDtoGet>()
            .ForMember(x => x.Fights, map =>
            map.MapFrom(x => x.Fighters));

        }
    }
}

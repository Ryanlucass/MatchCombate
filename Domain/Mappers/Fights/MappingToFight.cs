using AutoMapper;
using Domain.Dtos;
using Domain.Model;

namespace Domain.Mappers.Fights
{
    public class MappingToFight : Profile
    {
        public MappingToFight()
        {
            //CreateMap<Fight, FightDto>();
            CreateMap<FightDto, Fight>()
            .ForMember(x => x.Date, map =>
            map.MapFrom(x => x.Date.ToString("dddd, dd MMMM yyyy HH:mm")))
            .ReverseMap();

            //fazer um específico para o get

        }
    }
}

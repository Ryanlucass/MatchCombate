using AutoMapper;
using Domain.Dtos.FighterDtos;
using Domain.Model;
using System;

namespace Domain.Mappers
{

    public class MappingFighter : Profile
    {
        public MappingFighter()
        {
            // FighterDto => Fighter
            CreateMap<FighterDto, Fighter>()
            .ForMember(x => x.CreateAt, map =>
            map.MapFrom(x => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm")))
            .ForMember(x => x.FightId, map =>
            map.MapFrom(x => x.FightId == 0 ? null : x.FightId));

            // Fighter => FighterDtoGet
            CreateMap<Fighter, FighterDtoGet>()
            .ForMember(x => x.CreatedAt, map =>
            map.MapFrom(x => x.CreateAt.Value));
        }
    }
}

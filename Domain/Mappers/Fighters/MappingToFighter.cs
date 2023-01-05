using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.FighterDtos;
using Domain.Model;
using System;

namespace Domain.Mappers.Fighters
{

    public class MappingToFighter : Profile
    {
        public MappingToFighter()
        {
            CreateMap<FighterDto, Fighter>()
            .ForMember(x => x.CreateAt, map =>
            map.MapFrom(x => DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm")))
            .ForMember(x => x.FightId, map =>
            map.MapFrom(x => x.FightId == 0 ? null : x.FightId));
        }
    }
}

using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.FighterDtos;
using Domain.Model;
using System;

namespace Domain.Mappers
{

    public class MappingToFighter : Profile
    {
        public MappingToFighter()
        {
            CreateMap<FighterDto, Fighter>()
            .ForMember(x => x.CreateAt, map =>
            map.MapFrom(x=> DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm")));
        }
    }
}

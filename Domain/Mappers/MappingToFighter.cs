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
            CreateMap<FighterDto, Fighter>();
        }
    }
}

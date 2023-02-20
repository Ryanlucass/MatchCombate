using AutoMapper;
using Domain.Dtos;
using Domain.Model;
using System;

namespace Domain.Mappers
{

    public class MappingFighter : Profile
    {
        public MappingFighter()
        {
            CreateMap<FighterCreate, Fighter>() 
            .ReverseMap();

            CreateMap<Fighter, FighterResult>()
            .ReverseMap();
        }
    }
}

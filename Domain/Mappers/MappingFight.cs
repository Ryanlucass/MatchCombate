using AutoMapper;
using Domain.Dtos;
using Domain.Model;
using System;

namespace Domain.Mappers
{
    public class MappingFight : Profile
    {
        public MappingFight()
        {
            //FightCreate => Fight
            CreateMap<FightDto, Fight>()
            .ReverseMap();
            
        }
    }
}

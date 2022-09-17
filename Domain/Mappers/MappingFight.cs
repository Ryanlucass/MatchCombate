using AutoMapper;
using Domain.Dtos;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mappers
{
    public class MappingFight : Profile
    {
        public MappingFight()
        {
            CreateMap<Fight, FightDto>()
                .ReverseMap();
        }
    }
}

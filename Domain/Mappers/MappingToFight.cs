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
    public class MappingToFight : Profile
    {
        public MappingToFight()
        {
            CreateMap<Fight, FightDto>();
        }
    }
}

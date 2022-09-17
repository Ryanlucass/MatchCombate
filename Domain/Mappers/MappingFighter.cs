﻿using AutoMapper;
using Domain.Dtos;
using Domain.Model;
using System;

namespace Domain.Mappers
{
    public class MappingToFighter : Profile
    {
        public MappingToFighter()
        {
            CreateMap<Fighter, FighterDto>();
        }
    }

    public class MappingToFighterDto : Profile
    {
        public MappingToFighterDto()
        {
            CreateMap<FighterDto, Fighter>()
                .ForMember(fight => fight.CreateAt, map =>
                  map.MapFrom(dto => dto.CreateAt == DateTime.MinValue ? DateTime.Now : dto.CreateAt));
        }
    }
}
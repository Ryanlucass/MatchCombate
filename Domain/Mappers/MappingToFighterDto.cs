using AutoMapper;
using Domain.Dtos;
using Domain.Dtos.FighterDtos;
using Domain.Model;

namespace Domain.Mappers
{
    public class MappingToFighterDto : Profile
    {
        public MappingToFighterDto()
        {           
            CreateMap<Fighter, FighterDto>();

            CreateMap<Fighter, FighterDtoGet>()
            .ForMember(x=> x.CreatedAt, map =>
            map.MapFrom(x=> x.CreateAt.Value));
        }
    }
}

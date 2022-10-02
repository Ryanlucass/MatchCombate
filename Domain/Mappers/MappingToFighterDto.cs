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
            CreateMap<Fighter, FighterDto>()
                .ForMember(x => x.CreateAt, map =>
                map.MapFrom(f => f.CreateAt.Value.Date.ToString("dd - MM - yyyy")));
        }
    }
}

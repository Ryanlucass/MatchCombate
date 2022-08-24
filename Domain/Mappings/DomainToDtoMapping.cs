using AutoMapper;
using Domain.Dtos;
using Domain.Model;

namespace Domain.Mappings
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<Combat, CombatDto>();
        }
    }
}

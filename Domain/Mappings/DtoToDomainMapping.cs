using AutoMapper;
using Domain.Dtos;
using Domain.Model;

namespace Domain.Mappings
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<CombatDto, Combat>();
        }
    }
}

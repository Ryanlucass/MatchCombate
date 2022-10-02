using AutoMapper;
using Domain.Dtos.FighterDtos;
using Domain.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service
{
    public class MatchCombat : IMatchCombat
    {
        private readonly IFighterRepository _fighterRepository;
        private readonly IMapper _mapper;

        public MatchCombat(IFighterRepository repository, IMapper mapper)
        {
            _fighterRepository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Create a fighter
        /// </summary>
        /// <param name="fighter"></param>
        /// <returns></returns>
        public async Task<FighterDto> CreateFighter(FighterDtoCreate item)
        {
            //var fighterDto = _mapper.Map<Fighter>(fighter);
            var fighter = _mapper.Map<Fighter>(item);

            var result = await _fighterRepository.CreateAsync(fighter);

            return _mapper.Map<FighterDto>(result);
        }

        /// <summary>
        /// select every fithers or select by weight
        /// </summary>
        /// <returns></returns>
        public async Task<List<FighterDto>> SelectFighter( int? weightClass)
        { 
            var result = await _fighterRepository.GetFighteraAsync();

            var listFighterDto = result.Select(x =>
                new FighterDto()
                {
                    Id = x.Id,
                    CreateAt = (DateTime)x.CreateAt,
                    Name = x.Name,
                    NickName = x.NickName,
                    Cpf = x.Cpf,
                    WeightClass = x.WeightClass,
                    FightId = x.FightId
                }).ToList();

            if (weightClass != null)
            {
                var listbyweight = result.Where(x => x.WeightClass == weightClass).Select(x =>
                new FighterDto()
                {
                    Id = x.Id,
                    CreateAt = (DateTime)x.CreateAt,
                    Name = x.Name,
                    NickName = x.NickName,
                    Cpf = x.Cpf,
                    WeightClass = x.WeightClass,
                    FightId = x.FightId
                }).ToList();

                listFighterDto = listbyweight;
            }

            return listFighterDto;
        }

        public async Task<FighterDto> SelectFighterById(int id)
        {
            var result  = await _fighterRepository.GetByIdAsync(id);

            return _mapper.Map<FighterDto>(result);
            
        }

        public async Task<FighterDto> UpdateFighter(FighterDto fighterDto)
        {
            var fightExist = _fighterRepository.GetByIdAsync((int)fighterDto.Id).Result;
            
            if (fightExist == null)
            {
                throw new Exception($"Id: {fighterDto.Id} não existe");
            }

            //update do item
            fightExist.Name = fighterDto.Name ?? fightExist.Name;
            fightExist.Cpf = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.NickName = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.WeightClass = fighterDto.WeightClass != 0 ? fighterDto.WeightClass : fightExist.WeightClass;
            fightExist.FightId = fighterDto.FightId != null ? fighterDto.FightId : fightExist.FightId;
            fightExist.CreateAt = fighterDto.CreateAt != DateTime.MinValue ? fighterDto.CreateAt.Date : fightExist.CreateAt;

            var fighterUpdate = await _fighterRepository.UpdateAsync(fightExist);

            return _mapper.Map<FighterDto>(fighterUpdate);

        }

        public async Task<bool> DeleteFighter(int id) => await _fighterRepository.DeleteAsync(id);

    }
}

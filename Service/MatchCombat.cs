using AutoMapper;
using Data.Repository;
using Domain.Dtos;
using Domain.Exptions;
using Domain.Intefaces;
using Domain.Interfaces;
using Domain.Model;
using Pomelo.EntityFrameworkCore.MySql.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Service
{
    public class MatchCombat : IMatchCombat
    {
        private readonly IFighterRepository _fighterRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public MatchCombat(IFighterRepository repository, IMapper mapper, IUserRepository userRepository)
        {
            _fighterRepository = repository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<FighterResult> CreateFighter(FighterCreate item)
        {
            _ = string.IsNullOrEmpty(item.NickName) ? item.NickName = $"nick-{item?.Name.Split(' ')[0]}" : item.NickName;
  
            Validation( await _fighterRepository.GetByCodeIdAsync(item?.CodeId) != null, "Fighter Already exist!");

            Fighter fighter = _mapper.Map<Fighter>(item);
            Fighter resultFighter = await _fighterRepository.CreateAsync(fighter);

            return _mapper.Map<FighterResult>(resultFighter);
        }

        public async Task<List<FighterResult>> SelectFighter( int? weightClass)
        { 
            List<Fighter> listFight = await _fighterRepository.GetFighteraAsync();
            return weightClass >= 44.35 ?
                listFight.Where(x => x.WeightClass == weightClass).Select(x => _mapper.Map<FighterResult>(x)).ToList() :
                listFight.Select(x => _mapper.Map<FighterResult>(x)).ToList();
        }

        public async Task<FighterResult> SelectFighterById(Guid id)
        {
            var result = await _fighterRepository.GetByIdAsync(id);
            return _mapper.Map<FighterResult>(result);
        }

        public async Task<FighterResult> UpdateFighter(FighterDtoPatch fighterDto, Guid id)
        {
            var fightExist = _fighterRepository.GetByIdAsync(id).Result;
            if (fightExist == null){throw new Exception($"Id: {id} não existe");}

            //update do item
            fightExist.Name = fighterDto.Name ?? fightExist.Name;
            fightExist.CodeId = fighterDto.Cpf ?? fightExist.CodeId;
            fightExist.NickName = fighterDto.NickName ?? fightExist.NickName;
            fightExist.WeightClass = fighterDto.WeightClass != 0 ? fighterDto.WeightClass : fightExist.WeightClass;
  

            var fighterUpdate = await _fighterRepository.UpdateAsync(fightExist);
            return _mapper.Map<FighterResult>(fighterUpdate);
        }

        public async Task<bool> DeleteFighter(Guid id) => await _fighterRepository.DeleteAsync(id);


    }
}

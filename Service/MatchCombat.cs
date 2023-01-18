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

        public async Task<FighterDtoGet> CreateFighter(FighterDto item)
        {
            Validator(item);
            if(_userRepository.GetByIdAsync(item.UserId).Result == null){throw new UserExecption("User_c", "User null");}
            Fighter fighter = _mapper.Map<Fighter>(item);
            Fighter resultFighter = await _fighterRepository.CreateAsync(fighter);

            return _mapper.Map<FighterDtoGet>(resultFighter);
        }

        public async Task<List<FighterDtoGet>> SelectFighter( int? weightClass)
        { 
            List<Fighter> listFight = await _fighterRepository.GetFighteraAsync();
            return weightClass >= 44.35 ?
                listFight.Where(x => x.WeightClass == weightClass).Select(x => _mapper.Map<FighterDtoGet>(x)).ToList() :
                listFight.Select(x => _mapper.Map<FighterDtoGet>(x)).ToList();
        }

        public async Task<FighterDtoGet> SelectFighterById(int id)
        {
            var result = await _fighterRepository.GetByIdAsync(id);
            return _mapper.Map<FighterDtoGet>(result);
        }

        public async Task<FighterDtoGet> UpdateFighter(FighterDtoPatch fighterDto, int id)
        {
            var fightExist = _fighterRepository.GetByIdAsync(id).Result;
            if (fightExist == null){throw new Exception($"Id: {id} não existe");}

            //update do item
            fightExist.Name = fighterDto.Name ?? fightExist.Name;
            fightExist.Cpf = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.NickName = fighterDto.NickName ?? fightExist.NickName;
            fightExist.WeightClass = fighterDto.WeightClass != 0 ? fighterDto.WeightClass : fightExist.WeightClass;
            fightExist.FightId = fighterDto.FightId != 0 ? fighterDto.FightId : fightExist.FightId;

            var fighterUpdate = await _fighterRepository.UpdateAsync(fightExist);
            return _mapper.Map<FighterDtoGet>(fighterUpdate);
        }

        public async Task<bool> DeleteFighter(int id) => await _fighterRepository.DeleteAsync(id);



        private void Validator (FighterDto item)
        {
            if (item.UserId.Equals(Guid.Empty)){throw new UserExecption("User_validator", "Userid default value");}
        }
    }
}

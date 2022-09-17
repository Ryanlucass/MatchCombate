using AutoMapper;
using Data.Repository;
using Domain.Dtos;
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

        public MatchCombat(IFighterRepository repository)
        {
            _fighterRepository = repository;
        }

        /// <summary>
        /// Create a fighter
        /// </summary>
        /// <param name="fighter"></param>
        /// <returns></returns>
        public async Task<FighterDto> CreateFighter(FighterDto fighter)
        {
            //TODO use mapper 
            Fighter primaryFigther = new()
            {
                Name = fighter.Name,
                Cpf = fighter.Cpf,
                NickName = fighter.NickName,
                WeightClass = fighter.WeightClass,
                CreateAt = DateTime.Now
            };

            var result = await _fighterRepository.CreateAsync(primaryFigther);

            return fighter;
        }

        /// <summary>
        /// select every fithers or select by weight
        /// </summary>
        /// <returns></returns>
        public async Task<List<FighterDto>> SelectFighter( int? weightClass)
        { 
            //TODO use mapper
            var result = await _fighterRepository.GetFighteraAsync();
 
            var listFighterDto = result.Select(x =>
                new FighterDto()
                {
                    Id = x.Id,
                    Cpf = x.Cpf,
                    Name = x.Name,
                    NickName = x.NickName,
                    WeightClass = x.WeightClass
                }).ToList();

            if(weightClass != null)
            {
                var listbyweight = result.Where(x => x.WeightClass == weightClass).Select(x =>
                new FighterDto()
                {
                    Id = x.Id,
                    Cpf = x.Cpf,
                    Name = x.Name,
                    NickName = x.NickName,
                    WeightClass = x.WeightClass
                }).ToList();

                listFighterDto = listbyweight;
            }

            return listFighterDto;
        }

        public async Task<FighterDto> SelectFighterById(int id)
        {
            var result  = await _fighterRepository.GetByIdAsync(id);

            return new FighterDto()
            {
                Id = result.Id,
                Name = result.Name,
                NickName = result.NickName,
                Cpf = result.Cpf,
                LutaId = result.FightId,
                WeightClass = result.WeightClass
            };
            
        }

        /// <summary>
        /// Update a fighter
        /// </summary>
        /// <param name="fighterDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<FighterDto> UpdateFighter(FighterDto fighterDto)
        {

            var fightExist = _fighterRepository.GetByIdAsync((int)fighterDto.Id).Result;
            
            if(fightExist == null)
            {
                throw new Exception($"Id: {fighterDto.Id} não existe");
            }

            //update do item
            fightExist.Name = fighterDto.Name ?? fightExist.Name;
            fightExist.Cpf = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.NickName = fighterDto.Cpf ?? fightExist.Cpf;
            fightExist.WeightClass = fighterDto.WeightClass != 0 ? fighterDto.WeightClass : fightExist.WeightClass;
            fightExist.FightId = fighterDto.LutaId != null ? fighterDto.LutaId : fightExist.FightId;
            fightExist.CreateAt = fighterDto.Date != DateTime.MinValue ? fighterDto.Date : fightExist.CreateAt;

            var fighterUpdate = await _fighterRepository.UpdateAsync(fightExist);

            if(fighterUpdate != null)
            {
                fighterDto.Id = fighterUpdate.Id;
                fighterDto.Name = fighterUpdate.Name;
                fighterDto.Cpf = fighterUpdate.Cpf;
                fighterDto.NickName = fighterUpdate.NickName;
                fighterDto.WeightClass = fighterUpdate.WeightClass;
                fighterDto.LutaId = fighterUpdate.FightId;
                fighterDto.Date = (DateTime)fighterUpdate.CreateAt;

                return fighterDto;
            }
            else { return null; }

        }

        /// <summary>
        /// delete a fighter
        /// </summary>
        /// <param name="fighterDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> DeleteFighter(int id)
        {
            var fighterDelete = await _fighterRepository.DeleteAsync(id);

            return fighterDelete;
        }


    }
}

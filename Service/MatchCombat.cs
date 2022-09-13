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

        /// <summary>
        /// Update a fighter
        /// </summary>
        /// <param name="fighterDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<FighterDto> UpdateFighter(FighterDto fighterDto)
        {

            Fighter primaryFigther = new()
            {
                Id = (int)fighterDto.Id,
                Name = fighterDto.Name,
                Cpf = fighterDto.Cpf,
                NickName = fighterDto.NickName,
                WeightClass = fighterDto.WeightClass,
                CreateAt = null
            };

            var fighterUpdate = await _fighterRepository.UpdateAsync(primaryFigther);

            if(fighterUpdate != null)
            {
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

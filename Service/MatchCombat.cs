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
        /// Crear um lutador
        /// </summary>
        /// <param name="fighter"></param>
        /// <returns></returns>
        public async Task<FighterDto> CreateFighter(FighterDto fighter)
        {
            //Mapear recebimento para a classe

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
        /// Retornar todos os lutadores
        /// </summary>
        /// <returns></returns>
        public async Task<List<FighterDto>> SelectFighter( int? weightClass)
        { 
            var result = await _fighterRepository.GetFighteraAsync();
 
            var listFighterDto = result.Select(x =>
                new FighterDto()
                {
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
                    Cpf = x.Cpf,
                    Name = x.Name,
                    NickName = x.NickName,
                    WeightClass = x.WeightClass
                }).ToList();

                listFighterDto = listbyweight;
            }

            return listFighterDto;
        }
    }
}

using Domain.Dtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    public class FightsController : ControllerBase
    {
        private readonly IFightService fightService;

        public FightsController(IFightService fightService)
        {
            this.fightService = fightService;
        }

        [HttpPost]
        public FightDto CreateLutador([FromBody] FightDto fighter) => fightService.CreateFight(fighter).Result;

        [HttpGet]
        public List<FightDto> GetFighters([FromQuery] DateTime? dateToday) => fightService.SelectAllFight(dateToday).Result;

        [HttpGet("{id}")]
        public FightDto GetFighter(int id) => fightService.SelectFight(id).Result;

        [HttpPut]
        public FightDto PutFighter(FightDto fighter) => fightService.UpdateFight(fighter).Result;

        [HttpDelete("{id}")]
        public bool DeleteFighter(int id) => fightService.DeleteFight(id).Result;
    }
}

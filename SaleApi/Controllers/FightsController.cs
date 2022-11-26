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
        public FightDtoGet CreateLutador([FromBody] FightDto fighter) => fightService.CreateFight(fighter).Result;

        [HttpGet]
        public List<FightDtoGet> GetFighters([FromQuery] DateTime? dateToday) => fightService.SelectAllFight(dateToday).Result;

        [HttpGet("{id}")]
        public FightDtoGet GetFighter(int id) => fightService.SelectFight(id).Result;

        [HttpPut("{id}")]
        public FightDtoGet PutFighter([FromBody] FightDtoPut fighter, int id) => fightService.UpdateFight(fighter, id).Result;

        [HttpDelete("{id}")]
        public bool DeleteFighter(int id) => fightService.DeleteFight(id).Result;
    }
}

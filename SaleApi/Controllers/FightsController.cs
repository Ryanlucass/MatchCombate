using Domain.Dtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public FightDtoGet GetFighter(Guid id) => fightService.SelectFight(id).Result;

        [HttpPatch("{id}")]
        public FightDtoGet PutFighter([FromBody] FightDtoPatch fighter, Guid id) => fightService.UpdateFight(fighter, id).Result;

        [HttpDelete("{id}")]
        public bool DeleteFighter(Guid id) => fightService.DeleteFight(id).Result;
    }
}

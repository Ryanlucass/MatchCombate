using Domain.Dtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

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
        [Route("create")]
        public IActionResult CreateLutador([FromBody] FightDto fighter)
        {
            //TODO ajeitar retorno

            var result = fightService.CreateFight(fighter).Result;

            return Ok(result);
        }

        [HttpGet]
        [Route("selectall")]
        public IActionResult GetFighters([FromQuery] DateTime? dateToday)
        {
            var result = fightService.SelectAllFight(dateToday).Result;

            return Ok(result);
        }

        [HttpGet("id")]
        public IActionResult GetFighter(int id)
        {
            var result = fightService.SelectFight(id).Result;

            return Ok(result);
        }

        [HttpPut]
        [Route("atech")]
        public IActionResult PutFighter(FightDto fighter)
        {
            var result = fightService.UpdateFight(fighter).Result;
            return Ok(result);

        }

        [HttpDelete("id")]
        public IActionResult DeleteFighter(int id)
        {
            var result = fightService.DeleteFight(id).Result;
            return Ok(result);

        }
    }
}

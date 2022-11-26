using Domain.Dtos.FighterDtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FightersController : ControllerBase
    {
        private readonly IMatchCombat matchLutas;
        public FightersController(IMatchCombat matchLutas)
        {
            this.matchLutas = matchLutas; 
        }

        [HttpPost]
        [SwaggerResponse(201, "Fighter create")]
        [SwaggerResponse(400, "Error to create a fighter, verify your body request")]
        public FighterDtoGet CreateLutador([FromBody] FighterDto fighter) => matchLutas.CreateFighter(fighter).Result;

        //todo Ajeitar variável do nome
        [HttpGet]
        public List<FighterDtoGet> GetFighters([FromQuery] int? weightClass) => matchLutas.SelectFighter(weightClass).Result;

        [HttpGet("{id}")]
        public FighterDtoGet GetFighter(int id) => matchLutas.SelectFighterById(id).Result;

        [HttpPatch("{id}")]
        public FighterDtoGet PatchFighter(FighterDtoPatch fighter, int id) => matchLutas.UpdateFighter(fighter, id).Result;

        [HttpDelete("{id}")]
        public bool DeleteFighter(int id) => matchLutas.DeleteFighter(id).Result;
    }
}

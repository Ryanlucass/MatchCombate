using Domain.Dtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
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
        public FighterResult CreateFighter([FromBody] FighterCreate fighter) => matchLutas.CreateFighter(fighter).Result;

        [HttpGet]
        public List<FighterResult> GetFighters([FromQuery] int? weightClass) => matchLutas.SelectFighter(weightClass).Result;

        [HttpGet("{id}")]
        public FighterResult GetFighter(Guid id) => matchLutas.SelectFighterById(id).Result;

        [HttpPatch("{id}")]
        public FighterResult PatchFighter(FighterDtoPatch fighter, Guid id) => matchLutas.UpdateFighter(fighter, id).Result;

        [HttpDelete("{id}")]
        public bool DeleteFighter(Guid id) => matchLutas.DeleteFighter(id).Result;
    }
} 
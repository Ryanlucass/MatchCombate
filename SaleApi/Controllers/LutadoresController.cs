using Domain.Dtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LutadoresController : ControllerBase
    {
        public IMatchCombat MatchLutas { get; set; }
        public LutadoresController(IMatchCombat matchLutas)
        {
            MatchLutas = matchLutas; 
        }

        [HttpPost]
        public IActionResult CreateLutador([FromBody] FighterDto fighter)
        {
            var result = MatchLutas.CreateFighter(fighter).Result;

            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetFighters([FromQuery] int? weightClass)
        {

            var result = MatchLutas.SelectFighter(weightClass).Result;

            return Ok(result);
        }
    }
}

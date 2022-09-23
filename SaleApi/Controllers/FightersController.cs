using Domain.Dtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FightersController : ControllerBase
    {
        public IMatchCombat MatchLutas { get; set; }
        public FightersController(IMatchCombat matchLutas)
        {
            MatchLutas = matchLutas; 
        }

        [HttpPost]
        [SwaggerResponse(201, "Lutador cadastrado")]
        [SwaggerResponse(400, "Erro ao cadastrar lutador")]
        [Route("create")]
        public IActionResult CreateLutador([FromBody] FighterDto fighter)
        {
            
            var result = MatchLutas.CreateFighter(fighter).Result;

            return Ok(result);
        }

        [HttpGet]
        [Route("selectall")]
        public IActionResult GetFighters([FromQuery] int? weightClass)
        {
            var result = MatchLutas.SelectFighter(weightClass).Result;

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetFighter(int id)
        {
            var result = MatchLutas.SelectFighterById(id).Result;
            return Ok(result);
        }

        [HttpPut]
        [Route("atech")]
        public IActionResult PutFighter(FighterDto fighter)
        {
            var result = MatchLutas.UpdateFighter(fighter).Result;
            return Ok(result);

        }
        

        [HttpDelete("{id}")]
        public IActionResult DeleteFighter(int id)
        {
            var result = MatchLutas.DeleteFighter(id).Result;
            return Ok(result);

        }


    }
}

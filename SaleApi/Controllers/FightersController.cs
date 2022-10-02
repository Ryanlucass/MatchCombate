using Domain.Dtos.FighterDtos;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerResponse(201, "Lutador cadastrado")]
        [SwaggerResponse(400, "Erro ao cadastrar lutador")]
        [Route("create")]
        public IActionResult CreateLutador([FromBody] FighterDtoCreate fighter)
        {
            var result = matchLutas.CreateFighter(fighter).Result;
            return Ok(result);
        }

        [HttpGet]
        [Route("selectall")]
        public IActionResult GetFighters([FromQuery] int? weightClass)
        {
            var result = matchLutas.SelectFighter(weightClass).Result;

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetFighter(int id)
        {
            var result = matchLutas.SelectFighterById(id).Result;
            return Ok(result);
        }

        [HttpPut]
        [Route("atech")]
        public IActionResult PutFighter(FighterDto fighter)
        {
            var result = matchLutas.UpdateFighter(fighter).Result;
            return Ok(result);

        }
        

        [HttpDelete("{id}")]
        public IActionResult DeleteFighter(int id)
        {
            var result = matchLutas.DeleteFighter(id).Result;
            return Ok(result);

        }


    }
}

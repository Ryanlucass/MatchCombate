using Microsoft.AspNetCore.Mvc;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    public class FightsController : ControllerBase
    {

        public FightsController()
        {

        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateLutador([FromBody] FighterDto fighter)
        {
            //TODO ajeitar retorno

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

        [HttpGet]
        public IActionResult GetFighter()
        {
            return null;
        }

        [HttpPut]
        [Route("atech")]
        public IActionResult PutFighter(FighterDto fighter)
        {
            var result = MatchLutas.UpdateFighter(fighter).Result;
            return Ok(result);

        }

        [HttpDelete("id")]
        public IActionResult DeleteFighter(int id)
        {
            var result = MatchLutas.DeleteFighter(id).Result;
            return Ok(result);

        }
    }
}

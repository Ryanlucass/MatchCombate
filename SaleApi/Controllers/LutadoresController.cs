using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LutadoresController : ControllerBase
    {
        public IMatchLutas MatchLutas { get; set; }
        public LutadoresController(IMatchLutas matchLutas)
        {
            MatchLutas = matchLutas; 
        }

        [HttpGet]
        public IActionResult GetLutadores()
        {
            MatchLutas.CancelFight();

            return Ok();
        }
    }
}

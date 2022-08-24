using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dtos;
using Domain.Intefaces;
using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult CreateLutador()
        {

            return Ok();
        }
    }
}

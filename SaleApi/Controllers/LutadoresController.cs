using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatchCombate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LutadoresController : ControllerBase
    {
        public LutadoresController()
        {

        }

        [HttpGet]
        public IActionResult GetLutadores()
        {

            return Ok();
        }
    }
}

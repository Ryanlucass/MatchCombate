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
        public IMatchLutas MatchLutas { get; set; }
        public LutadoresController(IMatchLutas matchLutas)
        {
            MatchLutas = matchLutas; 
        }

        [HttpPost]
        public IActionResult CreateLutador([FromBody] LutadorDto lutador)
        {
            Fighter fighter = new()
            {
                Nome = lutador.Nome,
                Apelido = lutador.Apelido,
                ArteMarcial = lutador.ArteMarcial,
                Cpf = lutador.Cpf,
                Categoria = lutador.Categoria
            };

            MatchLutas.CreateLutador(fighter);

            return Ok();
        }
    }
}

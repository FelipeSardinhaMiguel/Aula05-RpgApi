using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpgAPI.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using RpgAPI.Models.Enuns;

namespace RpgAPI.Controllers
{
    public class ArmaController
    {
        [ApiController]
        [Route("[controller]")]
        public class ArmasController : ControllerBase
        {
            private static List<Arma> arma = new List<Arma>()
            {
                new Arma() { Id = 1, Nome = "Treisoitão", Dano = 38, Tipo = "Medio Alcance"},
                new Arma() { Id = 2, Nome = "M4", Dano = 30, Tipo = "Longo Alcance"},
                new Arma() { Id = 3, Nome = "AK47", Dano = 40, Tipo = "Longo Alcance"},
                new Arma() { Id = 4, Nome = "Coquetel Molotov", Dano = 5*7, Tipo = "Arremessável"},
                new Arma() { Id = 5, Nome = "Lança Chamas", Dano = 10*13, Tipo = "Longo alcance"},
                new Arma() { Id = 6, Nome = "Espada de Grama", Dano = 70, Tipo = "Corpo a corpo"},
                new Arma() { Id = 7, Nome = "Ominitrix", Dano = 100, Tipo = "Corpo a Corpo"}
            };
            
            [HttpGet("Get")]
            public IActionResult GetFirst()
            {
                Arma a = arma [0];
                return Ok(a);
            }

            [HttpGet("GetAll")]
            public IActionResult Get()
            {
                return Ok(arma);
            }

            [HttpGet("id{id}")]
            public IActionResult GetSingle(int id)
            {
                return Ok(arma.FirstOrDefault(ar=> ar.Id == id));
            }

        }
    }
}
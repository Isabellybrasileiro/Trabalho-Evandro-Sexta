using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeRandomizerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SorteioController : ControllerBase
    {
        private readonly List<string> funSorteio = new List<string>
        {
            "Funcionario 01",
            "Funcionario 02",
            "Funcionario 03",
            "Funcionario 04",
            "Funcionario 05"
        };

        private readonly Random random = new Random();

        [HttpGet]
        public ActionResult<string> GetRandomFunSorteio()
        {
            if (funSorteio.Any())
            {
                int randomIndex = random.Next(funSorteio.Count);
                string randomFunSorteio = funSorteio[randomIndex];
                return Ok(randomFunSorteio);
            }
            else
            {
                return NotFound("Nenhum funcionário disponível.");
            }
        }
    }
}
using Curso.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarterController : MainController
    {
        [HttpGet]
        public string Get()
        {
            var rng = new Random();
            return "[OK - Rodando]";
        }
    }
}

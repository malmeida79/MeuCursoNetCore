using Curso.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarterController : MainController
    {
        [HttpGet]
        public string Get()
        {
            return "[OK - Rodando]";
        }
    }
}

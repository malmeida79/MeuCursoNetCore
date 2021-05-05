using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancosController : MainController<Banco, IBancoService>
    {
        public BancosController(IServiceProvider provider) : base(provider)
        {

        }

        /// <summary>
        /// Metodo que apenas o banco pode usar, poius nao esta na main controller
        /// apenas em sua propria controller.
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("teste")]
        public virtual IActionResult Teste()
        {
            try
            {
                return Ok("Ola Jhonny!");
            }
            catch (Exception ex)
            {
                return Ok($"ocorreu erro:{ex.Message}");
            }
        }


    }
}

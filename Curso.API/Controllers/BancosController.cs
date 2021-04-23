using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancosController
    {
        private readonly IBancoRepository _banco;

        public BancosController(IBancoRepository banco)
        {
            _banco = banco;
        }

        [HttpGet]
        public List<Banco> Get()
        {
            return _banco.GetBancos();
        }

    }
}

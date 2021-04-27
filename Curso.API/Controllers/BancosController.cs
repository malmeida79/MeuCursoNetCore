using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancosController : MainController
    {
        private readonly IBancoService _banco;

        public BancosController(IBancoService banco)
        {
            _banco = banco;
        }

        [HttpGet]
        public List<Banco> Get()
        {
            return _banco.GetBancos();
        }

        [HttpGet("{id}")]
        public Banco Get(int id)
        {
            return _banco.GetBancosById(id);
        }

    }
}

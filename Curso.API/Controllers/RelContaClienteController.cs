using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelContaClienteController : MainController<RelContaCliente, IRelContaClienteService>
    {
        public RelContaClienteController(IServiceProvider provider) : base(provider)
        {

        }

    }
}
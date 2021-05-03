using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : MainController<Cliente, IClienteService>
    {
        public ClientesController(IServiceProvider provider) : base(provider)
        {

        }

    }
}
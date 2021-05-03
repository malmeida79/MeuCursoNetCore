using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancosController : MainController<Banco, IBancoService>
    {
        public BancosController(IServiceProvider provider) : base(provider)
        {

        }     

    }
}

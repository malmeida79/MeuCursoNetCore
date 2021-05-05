using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaInvestimentoController : MainController<ContaInvestimento, IContaInvestimentoService>
    {
        public ContaInvestimentoController(IServiceProvider provider) : base(provider)
        {

        }

    }
}
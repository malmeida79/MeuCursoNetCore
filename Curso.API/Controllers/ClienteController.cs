using Curso.API.Controllers.Base;
using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Curso.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : MainController
    {
        private readonly IClienteRepository _cliente;

        public ClientesController(IClienteRepository cliente)
        {
            _cliente = cliente;
        }

        [HttpGet]
        public List<Cliente> Get()
        {
            return _cliente.GetClientes();
        }

        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _cliente.GetClientesById(id);
        }

    }
}

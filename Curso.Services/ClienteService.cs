using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Curso.Services.Base;
using System.Collections.Generic;

namespace Curso.Services
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _cliente;

        public ClienteService(IClienteRepository cliente) : base(cliente)
        {
            _cliente = cliente;
        }

    }
}

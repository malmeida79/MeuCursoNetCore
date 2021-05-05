using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Curso.Services.Base;

namespace Curso.Services
{
    public class RelContaClienteService : BaseService<RelContaCliente>, IRelContaClienteService
    {
        private readonly IRelContaClienteRepository _relContaCliente;

        public RelContaClienteService(IRelContaClienteRepository relContaCliente) : base(relContaCliente)
        {
            _relContaCliente = relContaCliente;
        }

    }
}

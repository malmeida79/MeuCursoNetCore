using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Infra.Repositories.Base;
using Curso.Infra.Repositories.Context;

namespace Curso.Infra.Repositories
{
    public class RelContaClienteRepository : BaseRepository<RelContaCliente>, IRelContaClienteRepository
    {
        public RelContaClienteRepository()
        {

        }

        public RelContaClienteRepository(BancosContext dbContext) : base(dbContext)
        {

        }
    }
}

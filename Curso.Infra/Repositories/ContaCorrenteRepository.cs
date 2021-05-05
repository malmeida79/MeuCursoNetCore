using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Infra.Repositories.Base;
using Curso.Infra.Repositories.Context;

namespace Curso.Infra.Repositories
{
    public class ContaCorrenteRepository : BaseRepository<ContaCorrente>, IContaCorrenteRepository
    {
        public ContaCorrenteRepository()
        {

        }

        public ContaCorrenteRepository(BancosContext dbContext) : base(dbContext)
        {

        }
    }
}

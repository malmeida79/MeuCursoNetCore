using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Infra.Repositories.Base;
using Curso.Infra.Repositories.Context;

namespace Curso.Infra.Repositories
{
    public class ContaInvestimentoRepository : BaseRepository<ContaInvestimento>, IContaInvestimentoRepository
    {
        public ContaInvestimentoRepository()
        {

        }

        public ContaInvestimentoRepository(BancosContext dbContext) : base(dbContext)
        {

        }
    }
}

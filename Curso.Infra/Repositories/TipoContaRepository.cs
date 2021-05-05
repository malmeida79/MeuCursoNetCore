using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Infra.Repositories.Base;
using Curso.Infra.Repositories.Context;

namespace Curso.Infra.Repositories
{
    public class TipoContaRepository : BaseRepository<TipoConta>, ITipoContaRepository
    {
        public TipoContaRepository()
        {

        }

        public TipoContaRepository(BancosContext dbContext) : base(dbContext)
        {

        }
    }
}

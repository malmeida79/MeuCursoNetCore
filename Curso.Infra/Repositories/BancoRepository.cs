using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Infra.Repositories.Base;
using Curso.Infra.Repositories.Context;

namespace Curso.Infra.Repositories
{
    public class BancoRepository : BaseRepository<Banco>, IBancoRepository
    {
        public BancoRepository(BancosContext dbContext) : base(dbContext)
        {

        }

        public BancoRepository()
        {

        }

    }
}

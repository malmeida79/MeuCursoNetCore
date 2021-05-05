using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Curso.Services.Base;

namespace Curso.Services
{
    public class ContaCorrenteService : BaseService<ContaCorrente>, IContaCorrenteService
    {
        private readonly IContaCorrenteRepository _ContaCorrente;

        public ContaCorrenteService(IContaCorrenteRepository ContaCorrente) : base(ContaCorrente)
        {
            _ContaCorrente = ContaCorrente;
        }

    }
}

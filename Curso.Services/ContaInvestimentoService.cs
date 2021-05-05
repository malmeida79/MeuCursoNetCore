using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Curso.Services.Base;

namespace Curso.Services
{
    public class ContaInvestimentoService : BaseService<ContaInvestimento>, IContaInvestimentoService
    {
        private readonly IContaInvestimentoRepository _contaInvestimento;

        public ContaInvestimentoService(IContaInvestimentoRepository contaInvestimento) : base(contaInvestimento)
        {
            _contaInvestimento = contaInvestimento;
        }

    }
}

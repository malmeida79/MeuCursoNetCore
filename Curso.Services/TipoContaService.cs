using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Curso.Services.Base;
using System.Collections.Generic;

namespace Curso.Services
{
    public class TipoContaService : BaseService<TipoConta>,ITipoContaService
    {
        private readonly ITipoContaRepository _tipoConta;

        public TipoContaService(ITipoContaRepository tipoConta):base(tipoConta)
        {
            _tipoConta = tipoConta;
        }
    }
}

using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using Curso.Services.Base;
using System.Collections.Generic;

namespace Curso.Services
{
    public class BancoService : BaseService<Banco>, IBancoService
    {
        private readonly IBancoRepository _banco;

        public BancoService(IBancoRepository banco) : base(banco)
        {
            _banco = banco;
        }

    }
}

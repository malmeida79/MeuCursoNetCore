using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Services
{
    public class BancoService : IBancoService
    {
        private readonly IBancoRepository _banco;

        public BancoService(IBancoRepository banco)
        {
            _banco = banco;
        }

        public List<Banco> GetBancos()
        {
            return _banco.GetBancos();
        }

        public Banco GetBancosById(int id)
        {
            return _banco.GetBancosById(id);
        }

        public Banco GetBancosByName(string nome)
        {
            return _banco.GetBancosByName(nome);
        }
    }
}

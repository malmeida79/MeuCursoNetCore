using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Services
{
    public class TipoContaService : ITipoContaService
    {
        private readonly ITipoContaRepository _TipoConta;

        public TipoContaService(ITipoContaRepository TipoConta)
        {
            _TipoConta = TipoConta;
        }

        public List<TipoConta> GetTipoConta()
        {
            return _TipoConta.GetTipoConta();
        }

        public TipoConta GetTipoContaById(int id)
        {
            return _TipoConta.GetTipoContaById(id);
        }

        public TipoConta GetTipoContaByName(string nome)
        {
            return _TipoConta.GetTipoContaByName(nome);
        }
    }
}

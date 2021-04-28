using Curso.Domain.Contracts.Services.Base;
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Domain.Contracts.Services
{
    public interface ITipoContaService : IBaseService<TipoConta>
    {
        public List<TipoConta> GetTipoConta();
        public TipoConta GetTipoContaByName(string nome);
        public TipoConta GetTipoContaById(int id);
    }
}

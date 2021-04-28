
using Curso.Domain.Contracts.Repositories.Base;
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Domain.Contracts.Repositories
{
    public interface ITipoContaRepository : IBaseReposiory<TipoConta>
    {
        public List<TipoConta> GetTipoConta();
        public TipoConta GetTipoContaByName(string nome);
        public TipoConta GetTipoContaById(int id);
    }
}

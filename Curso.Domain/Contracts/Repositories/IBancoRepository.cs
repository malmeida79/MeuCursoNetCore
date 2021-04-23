
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Domain.Contracts.Repositories
{
    public interface IBancoRepository
    {
        public List<Banco> GetBancos();
        public Banco GetBancosByName(string nome);
        public Banco GetBancosById(int id);
    }
}

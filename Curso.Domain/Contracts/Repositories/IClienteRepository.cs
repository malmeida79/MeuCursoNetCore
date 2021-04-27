
using Curso.Domain.Contracts.Repositories.Base;
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Domain.Contracts.Repositories
{
    public interface IClienteRepository : IBaseReposiory<Cliente>
    {
        public List<Cliente> GetClientes();
        public Cliente GetClientesByName(string nome);
        public Cliente GetClientesById(int id);
    }
}

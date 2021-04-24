
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Domain.Contracts.Repositories
{
    public interface IClienteRepository
    {
        public List<Cliente> GetClientes();
        public Cliente GetClientesByName(string nome);
        public Cliente GetClientesById(int id);
    }
}

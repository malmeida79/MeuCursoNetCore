using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Domain.Contracts.Services
{
    public interface IClienteService
    {
        public List<Cliente> GetClientes();
        public Cliente GetClientesByName(string nome);
        public Cliente GetClientesById(int id);
    }
}

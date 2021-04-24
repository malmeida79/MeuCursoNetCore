using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Contracts.Services;
using Curso.Domain.Entities;
using System.Collections.Generic;

namespace Curso.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _cliente;

        public ClienteService(IClienteRepository cliente)
        {
            _cliente = cliente;
        }

        public List<Cliente> GetClientes()
        {
            return _cliente.GetClientes();
        }

        public Cliente GetClientesById(int id)
        {
            return _cliente.GetClientesById(id);
        }

        public Cliente GetClientesByName(string nome)
        {
            return _cliente.GetClientesByName(nome);
        }
    }
}

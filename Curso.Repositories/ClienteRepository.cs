using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Curso.Repositories
{
    public class ClienteRepository : BaseRepository<Banco>, IClienteRepository
    {
        public Cliente GetClientesById(int id)
        {
            var pesquisa = GetClientes().Where(x => x.CodCliente == id).FirstOrDefault();
            return pesquisa;
        }

        public Cliente GetClientesByName(string nome)
        {
            var pesquisa = GetClientes().Where(x => x.NomeCliente.Contains(nome)).FirstOrDefault();
            return pesquisa;
        }

        public List<Cliente> GetClientes()
        {
            var retorno = new List<Cliente>();

            retorno.Add(new Cliente { CodCliente = 1, NomeCliente = "Marcos" });
            retorno.Add(new Cliente { CodCliente = 2, NomeCliente = "Mariana" });
            retorno.Add(new Cliente { CodCliente = 3, NomeCliente = "Matheus" });
            retorno.Add(new Cliente { CodCliente = 4, NomeCliente = "Jhonny" });

            return retorno;
        }

    }
}

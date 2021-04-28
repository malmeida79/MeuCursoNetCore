using Curso.Domain.Contracts.Repositories;
using Curso.Domain.Entities;
using Curso.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Curso.Repositories
{
    public class TipoContaRepository : BaseRepository<TipoConta>, ITipoContaRepository
    {
        public TipoConta GetTipoContaById(int id)
        {
            var pesquisa = GetTipoConta().Where(x => x.CodTipoConta == id).FirstOrDefault();
            return pesquisa;
        }

        public TipoConta GetTipoContaByName(string nome)
        {
            var pesquisa = GetTipoConta().Where(x => x.NomeTipoConta.Contains(nome)).FirstOrDefault();
            return pesquisa;
        }

        public List<TipoConta> GetTipoConta()
        {
            var retorno = new List<TipoConta>();

            retorno.Add(new TipoConta { CodTipoConta = 1, NomeTipoConta = "Marcos" });
            retorno.Add(new TipoConta { CodTipoConta = 2, NomeTipoConta = "Mariana" });
            retorno.Add(new TipoConta { CodTipoConta = 3, NomeTipoConta = "Matheus" });
            retorno.Add(new TipoConta { CodTipoConta = 4, NomeTipoConta = "Jhonny" });

            return retorno;
        }

    }
}

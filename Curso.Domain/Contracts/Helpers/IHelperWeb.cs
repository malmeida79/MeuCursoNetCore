using Curso.Domain.Containers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Curso.Domain.Contracts.Helpers
{
    public interface IHelperWeb
    {
        public string UrlBase { get; set; }
        RequestResultModel<List<T>> OnGet<T>(string controler, string metodo = null, string[] parametros = null);
        RequestResultModel OnPost(string controler, object objeto, string metodo = null);
        RequestResultModel OnPut(string controler, object objeto, string metodo = null);
        RequestResultModel OnDelete(string controler, string metodo = null, string[] parametros = null);
    }
}

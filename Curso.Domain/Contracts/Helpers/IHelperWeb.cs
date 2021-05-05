using Curso.Domain.Containers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Curso.Domain.Contracts.Helpers
{
    public interface IHelperWeb
    {
        public List<T> OnGet<T>(string endPoint);
        Task<RequestResultModel<T>> OnGetASync<T>(string controler, string metodo = null, string[] parametros = null);
        Task<RequestResultModel> OnPostASync(string controler, object objeto, string metodo = null);
        Task<RequestResultModel> OnPutASync(string controler, object objeto, string metodo = null);
        Task<RequestResultModel> OnDeleteASync(string controler, string metodo = null, string[] parametros = null);
    }
}

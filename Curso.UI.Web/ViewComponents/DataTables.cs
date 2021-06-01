using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso.UI.Web.ViewModels;

namespace Curso.UI.Web.ViewComponents
{
    public class DataTables : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string caminhoAjax, List<JSDataTableColum> colunas, JSDataTableConfig configs = null)
        {
            await Task.Run(() =>
            {
                var caminho = caminhoAjax.Split("/");

                ViewBag.Controller = caminho[0];
                ViewBag.Action = caminho[1];
                ViewBag.colunas = colunas;

                configs.CampoId = configs.CampoId.Trim().Replace(" ", "");
                configs.TableName = configs.TableName.Trim().Replace(" ", "");

                if (configs.PermiteSelecao)
                {
                    if (configs.DirecionaAposSelecao == true)
                    {
                        // se nao tem para onde direcionar nao pode direcionar entao
                        if (string.IsNullOrEmpty(configs.CaminhoRedirect))
                        {
                            configs.DirecionaAposSelecao = false;
                        }
                    }

                    if (!string.IsNullOrEmpty(configs.MetodoRetornoSelecao))
                    {
                        var redirect = configs.MetodoRetornoSelecao;

                        if (redirect[0] == '/')
                        {
                            redirect = redirect.Substring(1, redirect.Length - 1);
                        }

                        var caminhoRedir = redirect.Split("/");

                        if (caminhoRedir.Count() == 2)
                        {
                            ViewBag.ControllerRecebeSelecao = caminhoRedir[0];
                            ViewBag.ActionRecebeSelecao = caminhoRedir[1];
                        }
                    }
                }

                ViewBag.config = configs;

            });

            return View();
        }
    }
}
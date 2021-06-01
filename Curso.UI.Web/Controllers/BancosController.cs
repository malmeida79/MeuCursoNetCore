using Curso.Domain.Configs;
using Curso.Domain.Containers;
using Curso.Domain.Contracts.Helpers;
using Curso.Domain.Entities;
using Curso.Domain.Enuns;
using Curso.Domain.Model;
using Curso.UI.Web.Uteis;
using Curso.UI.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso.UI.Web.Controllers
{
    public class BancosController : Controller
    {

        private readonly IHelperWeb _web;
        private readonly IOptions<AppSettingsConfig> _settings;

        public BancosController(IHelperWeb web, IOptions<AppSettingsConfig> settings)
        {
            _web = web;
            _settings = settings;
            _web.UrlBase = _settings.Value.EndPointAddress?.ToString();
        }

        public IActionResult Index()
        {
            List<JSDataTableColum> colunas = new List<JSDataTableColum>
            {
                new JSDataTableColum() { Data = "codBanco", Name = "codBanco", Title = "Código" },
                new JSDataTableColum() { Data = "nomeBanco", Name = "nomeBanco", Title = "Banco" },
                new JSDataTableColum() { Data = "numeroBanco", Name = "numeroBanco", Title = "Número" },
            };

            ViewBag.colunas = colunas;

            JSDataTableConfig config = new JSDataTableConfig
            {
                AtivaPesquisa = false,
                ExibeEdit = true,
                CustomEdit = "<a href='#' onclick='modalEdita(\" + row[\"codBanco\"] + \");'>Editar</a>",
                ExibeDelete = true,
                CustomDelete = "<a href='#' onclick='modalExclui(\" + row[\"codBanco\"] + \");'>Editar</a>"
            };

            ViewBag.config = config;

            return View();
        }

        public ActionResult ModalExclui(int codExclui)
        {
            return View(codExclui);
        }

        public ActionResult ModalEdita(int codEdita)
        {
            var bco = new Banco();
            var lista = _web.OnGet<Banco>("bancos", null, new string[] { codEdita.ToString() });
            bco = lista.Data?.FirstOrDefault();
            return View(bco);
        }

        public ActionResult ModalNovo()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SalvarAlteracao(IFormCollection camposTela)
        {
            try
            {
                Banco banco = new Banco
                {
                    NomeBanco = camposTela["nomeBanco"].ToString(),
                    CodBanco = Convert.ToInt32(camposTela["codBanco"]),
                    NumeroBanco = camposTela["numeroBanco"].ToString(),
                    DataInclusao = Convert.ToDateTime(camposTela["DataInclusao"].ToString()),
                    DataAlteracao = DateTime.Now
                };

                RequestResultModel acao = _web.OnPut("bancos", banco);

                if (acao.Status == StatusResult.Success)
                {
                    return Json(new { error = false, message = "Dados Salvos com sucesso!" });
                }
                else
                {
                    return Json(new { error = true, message = acao.Messages[0].Text });
                }
            }
            catch (Exception)
            {
                return Json(new { error = true, message = "Ocorreu um erro! nada foi alterado." });
            }
        }

        [HttpPost]
        public JsonResult SalvarNovo(IFormCollection camposTela)
        {
            try
            {
                Banco banco = new Banco
                {
                    NomeBanco = camposTela["nomeBanco"].ToString(),
                    NumeroBanco = camposTela["numeroBanco"].ToString()
                };

                RequestResultModel acao = _web.OnPost("bancos", banco); ;

                if (acao.Status == StatusResult.Success)
                {
                    return Json(new { error = false, message = "Dados Salvos com sucesso!" });
                }
                else
                {
                    return Json(new { error = true, message = acao.Messages[0].Text });
                }
            }
            catch (Exception)
            {
                return Json(new { error = true, message = "Ocorreu um erro! nada foi alterado." });
            }
        }

        [HttpPost]
        public JsonResult Excluir(IFormCollection camposTela)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(camposTela["idExclui"]);
                RequestResultModel acao = _web.OnDelete("bancos", parametros: new string[] { id.ToString() });

                if (acao.Status == StatusResult.Success)
                {
                    return Json(new { error = false, message = "Dados excluídos com sucesso!" });
                }
                else
                {
                    return Json(new { error = true, message = acao.Messages[0].Text });
                }
            }
            catch (Exception)
            {
                return Json(new { error = true, message = "Ocorreu um erro! nada foi alterado." });
            }
        }

        public ActionResult AjaxHandler(DataTableAjaxPostModel dataTableModel = null)
        {
            var retorno = _web.OnGet<Banco>("bancos");

            return Ok(HelperDataTables.GetResponse(dataTableModel, retorno, new List<string>() { "nomeBanco", "NumeroBanco" }));
        }
    }
}

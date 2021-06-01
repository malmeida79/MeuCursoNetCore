using Curso.Domain.Configs;
using Curso.Domain.Containers;
using Curso.Domain.Contracts.Helpers;
using Curso.Domain.Entities;
using Curso.Domain.Enuns;
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
            ViewBag.bancos = GetBancos();
            return View();
        }

        private List<Banco> GetBancos(bool insertSelecione = true)
        {
            var Bancos = _web.OnGet<Banco>("bancos");
            var BancosData = Bancos.Data?.OrderBy(x => x.NomeBanco).ToList() ?? new List<Banco>();
            if (insertSelecione)
            {
                BancosData.Insert(0, new Banco { CodBanco = 0, NomeBanco = "Selecione" });
            }
            return BancosData;
        }

        public ActionResult ModalExclui(int codExclui)
        {
            return View(codExclui);
        }

        public ActionResult ModalEdita(int codEdita)
        {
            var bco = new Banco();
            var lista = _web.OnGetEntity<Banco>("bancos", null, new string[] { codEdita.ToString() });
            bco = lista.Data;
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
    }
}

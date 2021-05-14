using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.UI.Web.Controllers
{
    public class BancosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //private List<CentroCusto> GetCentroCusto(bool insertSelecione = true)
        //{
        //    var centrosCusto = _centroCusto.GetListaCentrosCusto();
        //    var centrosCustoData = centrosCusto.Data.OrderBy(x => x.CodigoCentroCusto).ToList();
        //    if (insertSelecione)
        //    {
        //        centrosCustoData.Insert(0, new CentroCusto { CentroCustoKey = 0, CodigoCentroCusto = "Selecione" });
        //    }
        //    return centrosCustoData;
        //}

        //        @model TRESCON.FluxoCaixa.Domain.Entities.Projetos
        //@{
        //            Layout = null;
        //            ViewBag.Title = "Editar";
        //        }

        //<div class="modal-dialog modal-dialog-centered modal-sm" role="document">
        //    <div class="modal-content">
        //        <div class="modal-header">
        //            <h4 class="modal-title" id="tituloItem">Alteração de projeto</h4>
        //            <button type = "button" class="close" data-dismiss="modal" aria-label="Close">
        //                <span aria-hidden="true">&times;</span>
        //            </button>
        //        </div>

        //        <form name = "frmEdita" id="frmEdita" method="post">
        //            <div class="modal-body">
        //                <div class="container-fluid pt-3">
        //                    <input type = "hidden" name="key" id="key" value="@Model.ProjetoKey" />
        //                    <br />
        //                    <div class="row mb-2">
        //                        <div class="col-2">
        //                            Nome Projeto:
        //                        </div>
        //                        <div class="col-10 text-left">
        //                            <input type = "text" class="form-control" id="descricao" name="descricao" value="@Model.NomeProjeto">
        //                        </div>
        //                    </div>
        //                    <div class="row mb-2">
        //                        <div class="col-2">
        //                            Tipo Projeto:
        //                        </div>
        //                        <div class="col-10 text-left">
        //                            <select class="form-control" asp-for="TipoProjetoKey" name="tipo" id="tipo" asp-items="@(new SelectList(ViewBag.tipos,"TipoProjetoKey", "TipoProjetoDescricao"))"></select>
        //                        </div>
        //                    </div>
        //                    <div class="row mb-2">
        //                        <div class="col-2">
        //                            Situação Projeto:
        //                        </div>
        //                        <div class="col-10 text-left">
        //                            <select class="form-control" asp-for="SituacaoProjetoKey" name="situacao" id="situacao" asp-items="@(new SelectList(ViewBag.situacoes,"SituacaoProjetoKey", "SituacaoProjetoDescricao"))"></select>
        //                        </div>
        //                    </div>
        //                    <div class="row mb-2">
        //                        <div class="col-2">
        //                            Centro de custo:
        //                        </div>
        //                        <div class="col-10 text-left">
        //                            <select id = "centroCustoKey" asp-for="CentroCustoKey" class="form-control" name="centroCustoKey" asp-items="@(new SelectList(ViewBag.ccusto, "CentroCustoKey", "CodigoCentroCusto"))"></select>
        //                        </div>
        //                    </div>
        //                    <div class="row mb-2">
        //                        <div class="col-2">
        //                            Código projeto no Uno:
        //                        </div>
        //                        <div class="col-10 text-left">
        //                            <input type = "text" class="form-control" id="codProjetoUno" name="codProjetoUno" value="@Model.CodProjetoUno" readonly>
        //                        </div>
        //                    </div>
        //                    <div class="row mb-2">
        //                        <div class="col-2">
        //                            Ativo:
        //                        </div>
        //                        <div class="col-4 text-left">
        //                            <input type = "radio" id="ativo" name="ativo" value="sim" @if(Model.Ativo) { @Html.Raw("checked") }> Sim
        //<input type="radio" id="ativo" name="ativo" value="nao" @if (!Model.Ativo) { @Html.Raw("checked") }> Não
        //</div>
        //                    </div>
        //                    <div class="modal-footer mt-2">
        //                        <button type = "button" class="btn btn-primary" onclick="salvarAlteracao()">Salvar</button>
        //                        <button type = "button" class="btn btn-danger" data-dismiss="modal">Fechar</button>
        //                    </div>
        //                </div>
        //            </div>
        //        </form>
        //    </div>
        //</div>

        //        <script>

        //    function modalExclui(codigo)
        //        {

        //            var endereco = '@Url.Action("ModalExclui", "Funcoes", new { @codExclui =-1})'.replace(-1, codigo);

        //        $("#baseModal").load(endereco, function() {
        //            $("#baseModal").modal();
        //            });
        //        }

        //        function modalEdita(codigo)
        //        {

        //            var endereco = '@Url.Action("ModalEdita", "Projetos", new { @codEdita =-1})'.replace(-1, codigo);

        //        $("#baseModal").load(endereco, function() {
        //            $("#baseModal").modal();
        //            });
        //        }

        //        function modalNovo()
        //        {

        //            var endereco = '@Url.Action("ModalNovo", "Projetos")';

        //        $("#baseModal").load(endereco, function() {
        //            $("#baseModal").modal();
        //            });
        //        }

        //        function salvarAlteracao()
        //        {
        //        $.ajax({
        //                type: 'POST',
        //            url: '@Url.Action("SalvarAlteracao", "Projetos")',
        //            data: $('#frmEdita').serialize(),
        //            success: function(response) {
        //                    if (response.error)
        //                    {
        //                        toastr.error(response.message);
        //                        return;
        //                    }

        //                    toastr.success(response.message);

        //                $("#baseModal").modal('hide');

        //                    sleep(1500).then(() => {
        //                        window.location.reload();
        //                    });
        //                },
        //            error: function(response) {
        //                    toastr.error(response.message);
        //                }
        //            });
        //        }

        //        function salvarNovo()
        //        {
        //        $.ajax({
        //                type: 'POST',
        //            url: '@Url.Action("SalvarNovo", "Projetos")',
        //            data: $('#frmNovo').serialize(),
        //            success: function(response) {
        //                    if (response.error)
        //                    {
        //                        toastr.error(response.message);
        //                        return;
        //                    }

        //                    toastr.success(response.message);

        //                $("#baseModal").modal('hide');

        //                    sleep(1500).then(() => {
        //                        window.location.reload();
        //                    });
        //                },
        //            error: function(response) {
        //                    toastr.error(response.message);
        //                }
        //            });
        //        }

        //        function excluir()
        //        {

        //        $.ajax({
        //                type: 'POST',
        //            url: '@Url.Action("Excluir", "Projetos")',
        //            data: $('#frmExclui').serialize(),
        //            success: function(response) {
        //                    if (response.error)
        //                    {
        //                        toastr.error(response.message);
        //                        return;
        //                    }

        //                    toastr.success(response.message);

        //                $("#baseModal").modal('hide');

        //                    sleep(1500).then(() => {
        //                        window.location.reload();
        //                    });
        //                },
        //            error: function(response) {
        //                    toastr.error(response.message);
        //                }
        //            });
        //        }

        //</script>


    }
}

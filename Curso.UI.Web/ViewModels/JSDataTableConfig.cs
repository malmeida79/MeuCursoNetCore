namespace Curso.UI.Web.ViewModels
{
    public class JSDataTableConfig
    {
        public JSDataTableConfig()
        {
            UsarSeparadorAcoes = true;
            TextoEdit = "Editar";
            TextoDetail = "Detalhes";
            TextoDelete = "Delete";
            AtivaPesquisaStatus = false;
            CampoId = "ID";
            ExibeDelete = false;
            ExibeDetail = false;
            ExibeEdit = false;
            AtivaPesquisa = false;
            TableName = "ItensTable";
            DirecionaAposSelecao = false;
            PermiteSelecao = false;
        }

        public string TableName { get; set; }

        public bool ExibeEdit { get; set; }

        public string TextoEdit { get; set; }

        public string CustomEdit { get; set; }

        public bool ExibeDetail { get; set; }

        public string TextoDetail { get; set; }

        public string CustomDetail { get; set; }

        public bool ExibeDelete { get; set; }

        public string TextoDelete { get; set; }

        public string CustomDelete { get; set; }

        public bool UsarSeparadorAcoes { get; set; }

        public bool PermiteSelecao { get; set; }

        public string MetodoRetornoSelecao { get; set; }

        public string NomeGrid { get; set; }

        public bool DirecionaAposSelecao { get; set; }

        public string CaminhoRedirect { get; set; }

        public bool AtivaPesquisa { get; set; }

        public bool AtivaPesquisaStatus { get; set; }

        public string CampoId { get; set; }
    }
}

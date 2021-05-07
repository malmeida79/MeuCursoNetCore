using Curso.Domain.Contracts.Helpers;
using System;
using System.Windows.Forms;

namespace Curso.UI
{
    public partial class FrmPrincipal : Form
    {
        private readonly IHelperWeb _web;

        public FrmPrincipal(IHelperWeb web)
        {
            _web = web;
            _web.UrlBase = Properties.Settings.Default.EndPointAddress;
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            if (Msgs.Confirma("Deseja encerrar?") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            if (formISOpen("FrmCliente"))
            {
                return;
            }

            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuCI_Click(object sender, EventArgs e)
        {
            if (formISOpen("FrmContaInvestimento"))
            {
                return;
            }

            FrmContaInvestimento frm = new FrmContaInvestimento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuCC_Click(object sender, EventArgs e)
        {
            if (formISOpen("FrmContaCorrente"))
            {
                return;
            }

            FrmContaCorrente frm = new FrmContaCorrente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBancos_Click(object sender, EventArgs e)
        {
            if (formISOpen("FmrBanco"))
            {
                return;
            }

            FrmBanco frm = new FrmBanco(_web);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTipoConta_Click(object sender, EventArgs e)
        {
            if (formISOpen("FrmTipoConta"))
            {
                return;
            }

            FrmTipoConta frm = new FrmTipoConta();
            frm.MdiParent = this;
            frm.Show();

        }

        private bool formISOpen(string formName)
        {
            bool retorno = false;

            foreach (Form child in this.MdiChildren)
            {
                if (child.Text == formName)
                {
                    child.BringToFront();
                    return true;
                }
            }

            return retorno;
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}

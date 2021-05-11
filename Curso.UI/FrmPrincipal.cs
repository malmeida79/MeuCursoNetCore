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
            this.Text = $"{this.Text} - {DateTime.Now.ToString("dd/MM/yyyy") }";
        }

        #region Menus
        private void MnuSair_Click(object sender, EventArgs e)
        {
            if (Msgs.Confirma("Deseja encerrar?") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MnuClientes_Click(object sender, EventArgs e)
        {
            if (ChildISOpen("FrmCliente"))
            {
                return;
            }

            FrmCliente frm = new FrmCliente
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuCI_Click(object sender, EventArgs e)
        {
            if (ChildISOpen("FrmContaInvestimento"))
            {
                return;
            }

            FrmContaInvestimento frm = new FrmContaInvestimento
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuCC_Click(object sender, EventArgs e)
        {
            if (ChildISOpen("FrmContaCorrente"))
            {
                return;
            }

            FrmContaCorrente frm = new FrmContaCorrente
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuBancos_Click(object sender, EventArgs e)
        {
            if (ChildISOpen("FmrBanco"))
            {
                return;
            }

            FrmBanco frm = new FrmBanco(_web)
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MnuTipoConta_Click(object sender, EventArgs e)
        {
            if (ChildISOpen("FrmTipoConta"))
            {
                return;
            }

            FrmTipoConta frm = new FrmTipoConta
            {
                MdiParent = this
            };
            frm.Show();

        }

        private void MnuSobre_Click(object sender, EventArgs e)
        {

            FrmSobre frm = new FrmSobre();
            frm.ShowDialog();
        }

        private void MnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        #endregion

        #region Menu Contexto

        private void MnuFecharTodos_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        #endregion

        #region Toolbar

        private void ToolContaInvestimento_Click(object sender, EventArgs e)
        {
            MnuCI_Click(sender, e);
        }
        private void ToolClientes_Click(object sender, EventArgs e)
        {
            MnuClientes_Click(sender, e);
        }

        private void ToolContaCorrente_Click(object sender, EventArgs e)
        {
            MnuCC_Click(sender, e);
        }

        private void ToolTipoConta_Click(object sender, EventArgs e)
        {
            MnuTipoConta_Click(sender, e);
        }

        private void ToolBancos_Click(object sender, EventArgs e)
        {
            MnuBancos_Click(sender, e);
        }

        #endregion

        #region Internos

        private bool ChildISOpen(string formName)
        {
            bool retorno = false;

            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == formName)
                {
                    child.BringToFront();
                    return true;
                }
            }

            return retorno;
        }

        private bool FormISOpen(string formName)
        {
            bool retorno = false;

            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == formName)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        #endregion
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using Curso.CrossCutting.Uteis;
using Curso.Domain.Entities;

namespace Curso.UI
{
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            try
            {
                var listaBancos = HelperWeb.GetHttpClient<Banco>("bancos");

                if (listaBancos != null && listaBancos.Count > 0)
                {
                    listaBancos = listaBancos.OrderBy(x => x.NomeBanco).ToList();
                    cmbBancos.DisplayMember = "NomeBanco";
                    cmbBancos.ValueMember = "CodBanco";
                    cmbBancos.DataSource = listaBancos;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deu erro!");
            }

        }

        private void cmbBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeBanco.Text = cmbBancos.SelectedText;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Deseja realmente fechar?", ":: Fechar ::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (retorno == DialogResult.Yes) {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaBanco())
            {
                var bco = new Banco();
                bco.CodBanco = Convert.ToInt32(cmbBancos.SelectedValue.ToString());
                bco.NomeBanco = txtNomeBanco.Text;
            }
        }

        private void btnNovoBanco_Click(object sender, EventArgs e)
        {
            if (ValidaBanco())
            {
                var bco = new Banco();
                bco.CodBanco = 0;
                bco.NomeBanco = txtNomeBanco.Text;
            }
        }

        private bool ValidaBanco()
        {
            return !string.IsNullOrEmpty(txtNomeBanco.Text);
        }

    }
}


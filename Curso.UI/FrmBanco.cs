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
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Curso.CrossCutting.Uteis;
using Curso.Domain.Configs;
using Curso.Domain.Contracts.Helpers;
using Curso.Domain.Entities;
using Curso.Domain.Enuns;
using Microsoft.Extensions.Options;

namespace Curso.UI
{
    public partial class FrmBanco : Form
    {
        private List<Banco> listaBancos;
        private Banco bcoSel;
        private readonly IHelperWeb _web;

        public FrmBanco(IHelperWeb web)
        {
            _web = web;
            _web.UrlBase = Properties.Settings.Default.EndPointAddress;
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            try
            {
                var consulta = _web.OnGet<Banco>("bancos");

                if (consulta.Status == StatusResult.Success)
                {
                    listaBancos = consulta.Data;

                    if (listaBancos != null && listaBancos.Count > 0)
                    {
                        listaBancos = listaBancos.OrderBy(x => x.NomeBanco).ToList();
                        cmbBancos.DisplayMember = "NomeBanco";
                        cmbBancos.ValueMember = "CodBanco";
                        cmbBancos.DataSource = listaBancos;
                    }
                }
                else
                {
                    throw new Exception(consulta.Messages[0].Text);
                }
            }
            catch (Exception ex)
            {
                Msgs.Erro($"Erro na consulta: {ex.Message}");
            }
        }

        private void cmbBancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bcoSel = listaBancos.Find(x => x.CodBanco == Convert.ToInt32(cmbBancos.SelectedValue.ToString()));
            if (bcoSel != null)
            {
                txtNomeBanco.Text = bcoSel.NomeBanco;
                txtNumeroBanco.Text = bcoSel.NumeroBanco;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var retorno = Msgs.Confirma("Deseja realmente fechar?", ":: Fechar ::");
            if (retorno == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaBanco())
            {
                bcoSel.NomeBanco = txtNomeBanco.Text;
                bcoSel.NumeroBanco = txtNumeroBanco.Text;
            }
        }

        private void btnNovoBanco_Click(object sender, EventArgs e)
        {
            if (ValidaBanco())
            {
                bcoSel = new Banco();
                bcoSel.NomeBanco = txtNomeBanco.Text;
                bcoSel.NumeroBanco = txtNumeroBanco.Text;
            }
        }

        private bool ValidaBanco()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(txtNomeBanco.Text))
            {
                Msgs.Erro("Deve ser informado o nome do banco!");
                retorno = false;
            }
            else if (string.IsNullOrEmpty(txtNomeBanco.Text))
            {
                Msgs.Erro("Deve ser informado o número do banco!");
                retorno = false;
            }

            return retorno;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = Msgs.Confirma("Deseja realmente excluir?", ":: Fechar ::");
            if (retorno == DialogResult.Yes)
            {

            }
        }

        // if (formISOpen("Fila"))
        //    {
        //        return;
        //    }

        //private bool formISOpen(string formName)
        //{

        //    bool retorno = false;

        //    FormCollection fc = Application.OpenForms;

        //    foreach (Form frm in fc)
        //    {
        //        if (frm.Name == formName)
        //        {
        //            retorno = true;
        //        }
        //    }

        //    return retorno;
        //}
    }
}


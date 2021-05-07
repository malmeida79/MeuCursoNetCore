
namespace Curso.UI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBancos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipoConta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuJanela});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.AutoToolTip = true;
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBancos,
            this.mnuClientes,
            this.mnuContas,
            this.mnuSair});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastro.Text = "Cadastros";
            this.mnuCadastro.ToolTipText = "Cadastros em geral";
            // 
            // mnuBancos
            // 
            this.mnuBancos.Name = "mnuBancos";
            this.mnuBancos.Size = new System.Drawing.Size(116, 22);
            this.mnuBancos.Text = "Bancos";
            this.mnuBancos.Click += new System.EventHandler(this.mnuBancos_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(116, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuContas
            // 
            this.mnuContas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCC,
            this.mnuCI,
            this.mnuTipoConta});
            this.mnuContas.Name = "mnuContas";
            this.mnuContas.Size = new System.Drawing.Size(116, 22);
            this.mnuContas.Text = "Contas";
            // 
            // mnuCC
            // 
            this.mnuCC.Name = "mnuCC";
            this.mnuCC.Size = new System.Drawing.Size(178, 22);
            this.mnuCC.Text = "Conta Corrente";
            this.mnuCC.Click += new System.EventHandler(this.mnuCC_Click);
            // 
            // mnuCI
            // 
            this.mnuCI.Name = "mnuCI";
            this.mnuCI.Size = new System.Drawing.Size(178, 22);
            this.mnuCI.Text = "Conta Investimento";
            this.mnuCI.Click += new System.EventHandler(this.mnuCI_Click);
            // 
            // mnuTipoConta
            // 
            this.mnuTipoConta.Name = "mnuTipoConta";
            this.mnuTipoConta.Size = new System.Drawing.Size(178, 22);
            this.mnuTipoConta.Text = "Tipo Conta";
            this.mnuTipoConta.Click += new System.EventHandler(this.mnuTipoConta_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(116, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuJanela
            // 
            this.mnuJanela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHorizontal,
            this.mnuVertical,
            this.mnuCascata});
            this.mnuJanela.Name = "mnuJanela";
            this.mnuJanela.Size = new System.Drawing.Size(56, 20);
            this.mnuJanela.Text = "Janelas";
            // 
            // mnuHorizontal
            // 
            this.mnuHorizontal.Name = "mnuHorizontal";
            this.mnuHorizontal.Size = new System.Drawing.Size(129, 22);
            this.mnuHorizontal.Text = "Horizontal";
            this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(129, 22);
            this.mnuVertical.Text = "Vertical";
            this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
            // 
            // mnuCascata
            // 
            this.mnuCascata.Name = "mnuCascata";
            this.mnuCascata.Size = new System.Drawing.Size(129, 22);
            this.mnuCascata.Text = "Cascata";
            this.mnuCascata.Click += new System.EventHandler(this.mnuCascata_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = ":: Sistema Bancario ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuJanela;
        private System.Windows.Forms.ToolStripMenuItem mnuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuCascata;
        private System.Windows.Forms.ToolStripMenuItem mnuBancos;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuContas;
        private System.Windows.Forms.ToolStripMenuItem mnuCC;
        private System.Windows.Forms.ToolStripMenuItem mnuCI;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuTipoConta;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
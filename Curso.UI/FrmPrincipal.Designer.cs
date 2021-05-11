
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBancos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipoConta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFecharTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolContaInvestimento = new System.Windows.Forms.ToolStripButton();
            this.mnuBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuJanela,
            this.mnuAjuda});
            this.mnuBar.Location = new System.Drawing.Point(0, 0);
            this.mnuBar.MdiWindowListItem = this.mnuJanela;
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(800, 24);
            this.mnuBar.TabIndex = 1;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.AutoToolTip = true;
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBancos,
            this.mnuClientes,
            this.toolStripSeparator1,
            this.mnuContas,
            this.toolStripSeparator2,
            this.mnuSair});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastro.Text = "Cadastros";
            this.mnuCadastro.ToolTipText = "Cadastros em geral";
            // 
            // mnuBancos
            // 
            this.mnuBancos.Name = "mnuBancos";
            this.mnuBancos.Size = new System.Drawing.Size(135, 22);
            this.mnuBancos.Text = "Bancos";
            this.mnuBancos.Click += new System.EventHandler(this.MnuBancos_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuClientes.Size = new System.Drawing.Size(135, 22);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.MnuClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuContas
            // 
            this.mnuContas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCC,
            this.mnuCI,
            this.mnuTipoConta});
            this.mnuContas.Name = "mnuContas";
            this.mnuContas.Size = new System.Drawing.Size(135, 22);
            this.mnuContas.Text = "Contas";
            // 
            // mnuCC
            // 
            this.mnuCC.Name = "mnuCC";
            this.mnuCC.Size = new System.Drawing.Size(178, 22);
            this.mnuCC.Text = "Conta Corrente";
            this.mnuCC.Click += new System.EventHandler(this.MnuCC_Click);
            // 
            // mnuCI
            // 
            this.mnuCI.Name = "mnuCI";
            this.mnuCI.Size = new System.Drawing.Size(178, 22);
            this.mnuCI.Text = "Conta Investimento";
            this.mnuCI.Click += new System.EventHandler(this.MnuCI_Click);
            // 
            // mnuTipoConta
            // 
            this.mnuTipoConta.Name = "mnuTipoConta";
            this.mnuTipoConta.Size = new System.Drawing.Size(178, 22);
            this.mnuTipoConta.Text = "Tipo Conta";
            this.mnuTipoConta.Click += new System.EventHandler(this.MnuTipoConta_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(135, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.MnuSair_Click);
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
            this.mnuHorizontal.Click += new System.EventHandler(this.MnuHorizontal_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(129, 22);
            this.mnuVertical.Text = "Vertical";
            this.mnuVertical.Click += new System.EventHandler(this.MnuVertical_Click);
            // 
            // mnuCascata
            // 
            this.mnuCascata.Name = "mnuCascata";
            this.mnuCascata.Size = new System.Drawing.Size(129, 22);
            this.mnuCascata.Text = "Cascata";
            this.mnuCascata.Click += new System.EventHandler(this.MnuCascata_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAjuda.Text = "Ajuda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.MnuSobre_Click);
            // 
            // stsBar
            // 
            this.stsBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsBar.Location = new System.Drawing.Point(0, 427);
            this.stsBar.Name = "stsBar";
            this.stsBar.Size = new System.Drawing.Size(800, 22);
            this.stsBar.TabIndex = 3;
            this.stsBar.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFecharTodos});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 26);
            // 
            // mnuFecharTodos
            // 
            this.mnuFecharTodos.Name = "mnuFecharTodos";
            this.mnuFecharTodos.Size = new System.Drawing.Size(142, 22);
            this.mnuFecharTodos.Text = "Fechar todos";
            this.mnuFecharTodos.Click += new System.EventHandler(this.MnuFecharTodos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolContaInvestimento});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolContaInvestimento
            // 
            this.toolContaInvestimento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolContaInvestimento.Image = ((System.Drawing.Image)(resources.GetObject("toolContaInvestimento.Image")));
            this.toolContaInvestimento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolContaInvestimento.Name = "toolContaInvestimento";
            this.toolContaInvestimento.Size = new System.Drawing.Size(23, 22);
            this.toolContaInvestimento.Text = "Conta investimento";
            this.toolContaInvestimento.Click += new System.EventHandler(this.ToolContaInvestimento_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.mnuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuBar;
            this.Name = "FrmPrincipal";
            this.Text = ":: Sistema Bancário ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
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
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFecharTodos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolContaInvestimento;
    }
}
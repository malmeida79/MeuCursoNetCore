
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
            this.MnuBar = new System.Windows.Forms.MenuStrip();
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
            this.StsBar = new System.Windows.Forms.StatusStrip();
            this.CtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFecharTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBancos = new System.Windows.Forms.ToolStripButton();
            this.ToolClientes = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolContaInvestimento = new System.Windows.Forms.ToolStripButton();
            this.ToolContaCorrente = new System.Windows.Forms.ToolStripButton();
            this.ToolTipoConta = new System.Windows.Forms.ToolStripButton();
            this.MnuBar.SuspendLayout();
            this.CtxMenu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuBar
            // 
            this.MnuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro,
            this.mnuJanela,
            this.mnuAjuda});
            this.MnuBar.Location = new System.Drawing.Point(0, 0);
            this.MnuBar.MdiWindowListItem = this.mnuJanela;
            this.MnuBar.Name = "MnuBar";
            this.MnuBar.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MnuBar.Size = new System.Drawing.Size(1143, 35);
            this.MnuBar.TabIndex = 1;
            this.MnuBar.Text = "menuStrip1";
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
            this.mnuCadastro.Size = new System.Drawing.Size(107, 29);
            this.mnuCadastro.Text = "Cadastros";
            this.mnuCadastro.ToolTipText = "Cadastros em geral";
            // 
            // mnuBancos
            // 
            this.mnuBancos.Name = "mnuBancos";
            this.mnuBancos.Size = new System.Drawing.Size(206, 34);
            this.mnuBancos.Text = "Bancos";
            this.mnuBancos.Click += new System.EventHandler(this.MnuBancos_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuClientes.Size = new System.Drawing.Size(206, 34);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.MnuClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuContas
            // 
            this.mnuContas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCC,
            this.mnuCI,
            this.mnuTipoConta});
            this.mnuContas.Name = "mnuContas";
            this.mnuContas.Size = new System.Drawing.Size(206, 34);
            this.mnuContas.Text = "Contas";
            // 
            // mnuCC
            // 
            this.mnuCC.Name = "mnuCC";
            this.mnuCC.Size = new System.Drawing.Size(269, 34);
            this.mnuCC.Text = "Conta Corrente";
            this.mnuCC.Click += new System.EventHandler(this.MnuCC_Click);
            // 
            // mnuCI
            // 
            this.mnuCI.Name = "mnuCI";
            this.mnuCI.Size = new System.Drawing.Size(269, 34);
            this.mnuCI.Text = "Conta Investimento";
            this.mnuCI.Click += new System.EventHandler(this.MnuCI_Click);
            // 
            // mnuTipoConta
            // 
            this.mnuTipoConta.Name = "mnuTipoConta";
            this.mnuTipoConta.Size = new System.Drawing.Size(269, 34);
            this.mnuTipoConta.Text = "Tipo Conta";
            this.mnuTipoConta.Click += new System.EventHandler(this.MnuTipoConta_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(206, 34);
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
            this.mnuJanela.Size = new System.Drawing.Size(83, 29);
            this.mnuJanela.Text = "Janelas";
            // 
            // mnuHorizontal
            // 
            this.mnuHorizontal.Name = "mnuHorizontal";
            this.mnuHorizontal.Size = new System.Drawing.Size(196, 34);
            this.mnuHorizontal.Text = "Horizontal";
            this.mnuHorizontal.Click += new System.EventHandler(this.MnuHorizontal_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(196, 34);
            this.mnuVertical.Text = "Vertical";
            this.mnuVertical.Click += new System.EventHandler(this.MnuVertical_Click);
            // 
            // mnuCascata
            // 
            this.mnuCascata.Name = "mnuCascata";
            this.mnuCascata.Size = new System.Drawing.Size(196, 34);
            this.mnuCascata.Text = "Cascata";
            this.mnuCascata.Click += new System.EventHandler(this.MnuCascata_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(74, 29);
            this.mnuAjuda.Text = "Ajuda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(161, 34);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.MnuSobre_Click);
            // 
            // StsBar
            // 
            this.StsBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StsBar.Location = new System.Drawing.Point(0, 726);
            this.StsBar.Name = "StsBar";
            this.StsBar.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.StsBar.Size = new System.Drawing.Size(1143, 22);
            this.StsBar.TabIndex = 3;
            this.StsBar.Text = "statusStrip1";
            // 
            // CtxMenu
            // 
            this.CtxMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFecharTodos});
            this.CtxMenu.Name = "contextMenuStrip1";
            this.CtxMenu.Size = new System.Drawing.Size(188, 36);
            // 
            // mnuFecharTodos
            // 
            this.mnuFecharTodos.Name = "mnuFecharTodos";
            this.mnuFecharTodos.Size = new System.Drawing.Size(187, 32);
            this.mnuFecharTodos.Text = "Fechar todos";
            this.mnuFecharTodos.Click += new System.EventHandler(this.MnuFecharTodos_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.ContextMenuStrip = this.CtxMenu;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBancos,
            this.ToolClientes,
            this.ToolStripSeparator3,
            this.ToolContaInvestimento,
            this.ToolContaCorrente,
            this.ToolTipoConta});
            this.ToolBar.Location = new System.Drawing.Point(0, 35);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolBar.Size = new System.Drawing.Size(1143, 33);
            this.ToolBar.TabIndex = 5;
            this.ToolBar.Text = "toolStrip1";
            // 
            // ToolBancos
            // 
            this.ToolBancos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBancos.Image = ((System.Drawing.Image)(resources.GetObject("ToolBancos.Image")));
            this.ToolBancos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBancos.Name = "ToolBancos";
            this.ToolBancos.Size = new System.Drawing.Size(34, 28);
            this.ToolBancos.Text = "Bancos";
            this.ToolBancos.Click += new System.EventHandler(this.ToolBancos_Click);
            // 
            // ToolClientes
            // 
            this.ToolClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolClientes.Image = ((System.Drawing.Image)(resources.GetObject("ToolClientes.Image")));
            this.ToolClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolClientes.Name = "ToolClientes";
            this.ToolClientes.Size = new System.Drawing.Size(34, 28);
            this.ToolClientes.Text = "Clientes";
            this.ToolClientes.Click += new System.EventHandler(this.ToolClientes_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // ToolContaInvestimento
            // 
            this.ToolContaInvestimento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolContaInvestimento.Image = ((System.Drawing.Image)(resources.GetObject("ToolContaInvestimento.Image")));
            this.ToolContaInvestimento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolContaInvestimento.Name = "ToolContaInvestimento";
            this.ToolContaInvestimento.Size = new System.Drawing.Size(34, 28);
            this.ToolContaInvestimento.Text = "Conta investimento";
            this.ToolContaInvestimento.Click += new System.EventHandler(this.ToolContaInvestimento_Click);
            // 
            // ToolContaCorrente
            // 
            this.ToolContaCorrente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolContaCorrente.Image = ((System.Drawing.Image)(resources.GetObject("ToolContaCorrente.Image")));
            this.ToolContaCorrente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolContaCorrente.Name = "ToolContaCorrente";
            this.ToolContaCorrente.Size = new System.Drawing.Size(34, 28);
            this.ToolContaCorrente.Text = "Conta Corrente";
            this.ToolContaCorrente.Click += new System.EventHandler(this.ToolContaCorrente_Click);
            // 
            // ToolTipoConta
            // 
            this.ToolTipoConta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolTipoConta.Image = ((System.Drawing.Image)(resources.GetObject("ToolTipoConta.Image")));
            this.ToolTipoConta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolTipoConta.Name = "ToolTipoConta";
            this.ToolTipoConta.Size = new System.Drawing.Size(34, 28);
            this.ToolTipoConta.Text = "Tipo de Conta";
            this.ToolTipoConta.Click += new System.EventHandler(this.ToolTipoConta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 748);
            this.ContextMenuStrip = this.CtxMenu;
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.StsBar);
            this.Controls.Add(this.MnuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.Text = ":: Sistema Bancário ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MnuBar.ResumeLayout(false);
            this.MnuBar.PerformLayout();
            this.CtxMenu.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuBar;
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
        private System.Windows.Forms.StatusStrip StsBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ContextMenuStrip CtxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFecharTodos;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ToolContaInvestimento;
        private System.Windows.Forms.ToolStripButton ToolBancos;
        private System.Windows.Forms.ToolStripButton ToolClientes;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ToolContaCorrente;
        private System.Windows.Forms.ToolStripButton ToolTipoConta;
    }
}

namespace Curso.UI
{
    partial class FrmBanco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanco));
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovoBanco = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroBanco = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBancos
            // 
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(93, 12);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(493, 33);
            this.cmbBancos.TabIndex = 0;
            this.cmbBancos.SelectedIndexChanged += new System.EventHandler(this.cmbBancos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Banco:";
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(137, 57);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(448, 31);
            this.txtNomeBanco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSalvar.Location = new System.Drawing.Point(140, 163);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 45);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(493, 163);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(89, 43);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovoBanco
            // 
            this.btnNovoBanco.Location = new System.Drawing.Point(17, 163);
            this.btnNovoBanco.Name = "btnNovoBanco";
            this.btnNovoBanco.Size = new System.Drawing.Size(119, 43);
            this.btnNovoBanco.TabIndex = 3;
            this.btnNovoBanco.Text = "Novo Banco";
            this.btnNovoBanco.UseVisualStyleBackColor = true;
            this.btnNovoBanco.Click += new System.EventHandler(this.btnNovoBanco_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número Banco:";
            // 
            // txtNumeroBanco
            // 
            this.txtNumeroBanco.Location = new System.Drawing.Point(166, 102);
            this.txtNumeroBanco.Name = "txtNumeroBanco";
            this.txtNumeroBanco.Size = new System.Drawing.Size(420, 31);
            this.txtNumeroBanco.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Tomato;
            this.btnExcluir.Location = new System.Drawing.Point(253, 163);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 45);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 223);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovoBanco);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNumeroBanco);
            this.Controls.Add(this.txtNomeBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBancos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Bancos ::";
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovoBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroBanco;
        private System.Windows.Forms.Button btnExcluir;
    }
}


﻿
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
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbBancos
            // 
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(12, 12);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(574, 33);
            this.cmbBancos.TabIndex = 0;
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 281);
            this.Controls.Add(this.cmbBancos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Cadastro de Bancos ::";
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBancos;
    }
}


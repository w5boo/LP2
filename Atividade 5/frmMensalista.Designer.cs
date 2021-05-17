
namespace Pclasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.lblDataEntradaEmpresa = new System.Windows.Forms.Label();
            this.btnInstanciarMensalista = new System.Windows.Forms.Button();
            this.btnIMPP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(255, 132);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(128, 37);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(665, 132);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(165, 43);
            this.txtMatricula.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(665, 181);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 43);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(255, 181);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 37);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(665, 230);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(165, 43);
            this.txtSalarioMensal.TabIndex = 5;
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(255, 230);
            this.lblSalarioMensal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(190, 37);
            this.lblSalarioMensal.TabIndex = 4;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(665, 279);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(165, 43);
            this.txtDataEntradaEmpresa.TabIndex = 7;
            // 
            // lblDataEntradaEmpresa
            // 
            this.lblDataEntradaEmpresa.AutoSize = true;
            this.lblDataEntradaEmpresa.Location = new System.Drawing.Point(255, 279);
            this.lblDataEntradaEmpresa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataEntradaEmpresa.Name = "lblDataEntradaEmpresa";
            this.lblDataEntradaEmpresa.Size = new System.Drawing.Size(352, 37);
            this.lblDataEntradaEmpresa.TabIndex = 6;
            this.lblDataEntradaEmpresa.Text = "Data de Entrada na Empresa";
            // 
            // btnInstanciarMensalista
            // 
            this.btnInstanciarMensalista.Location = new System.Drawing.Point(281, 422);
            this.btnInstanciarMensalista.Name = "btnInstanciarMensalista";
            this.btnInstanciarMensalista.Size = new System.Drawing.Size(297, 115);
            this.btnInstanciarMensalista.TabIndex = 8;
            this.btnInstanciarMensalista.Text = "Instanciar Mensalista";
            this.btnInstanciarMensalista.UseVisualStyleBackColor = true;
            this.btnInstanciarMensalista.Click += new System.EventHandler(this.btnInstanciarMensalista_Click);
            // 
            // btnIMPP
            // 
            this.btnIMPP.Location = new System.Drawing.Point(838, 422);
            this.btnIMPP.Name = "btnIMPP";
            this.btnIMPP.Size = new System.Drawing.Size(369, 115);
            this.btnIMPP.TabIndex = 9;
            this.btnIMPP.Text = "Instanciar Mensalista Passando Parâmetros";
            this.btnIMPP.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 679);
            this.Controls.Add(this.btnIMPP);
            this.Controls.Add(this.btnInstanciarMensalista);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.lblDataEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.Label lblDataEntradaEmpresa;
        private System.Windows.Forms.Button btnInstanciarMensalista;
        private System.Windows.Forms.Button btnIMPP;
    }
}
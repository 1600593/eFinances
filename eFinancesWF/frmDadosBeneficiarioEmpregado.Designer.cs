namespace eFinancesWF
{
    partial class frmDadosBeneficiarioEmpregado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.txtUltimoNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDepto = new System.Windows.Forms.ComboBox();
            this.btnGerirCategoria = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados Beneficiários -- Empregados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primeiro Nome:";
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.Location = new System.Drawing.Point(135, 57);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(156, 20);
            this.txtPrimeiroNome.TabIndex = 3;
            // 
            // txtUltimoNome
            // 
            this.txtUltimoNome.Location = new System.Drawing.Point(135, 80);
            this.txtUltimoNome.Name = "txtUltimoNome";
            this.txtUltimoNome.Size = new System.Drawing.Size(156, 20);
            this.txtUltimoNome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Último Nome: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamento: ";
            // 
            // cboDepto
            // 
            this.cboDepto.FormattingEnabled = true;
            this.cboDepto.Location = new System.Drawing.Point(135, 159);
            this.cboDepto.Name = "cboDepto";
            this.cboDepto.Size = new System.Drawing.Size(303, 21);
            this.cboDepto.TabIndex = 7;
            // 
            // btnGerirCategoria
            // 
            this.btnGerirCategoria.Location = new System.Drawing.Point(444, 162);
            this.btnGerirCategoria.Name = "btnGerirCategoria";
            this.btnGerirCategoria.Size = new System.Drawing.Size(28, 19);
            this.btnGerirCategoria.TabIndex = 10;
            this.btnGerirCategoria.Text = "...";
            this.btnGerirCategoria.UseVisualStyleBackColor = true;
            this.btnGerirCategoria.Click += new System.EventHandler(this.btnGerirCategoria_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(157, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 37);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 37);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(135, 106);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(156, 20);
            this.txtTelefone.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correio Electrónico:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // frmDadosBeneficiarioEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 266);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnGerirCategoria);
            this.Controls.Add(this.cboDepto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUltimoNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrimeiroNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDadosBeneficiarioEmpregado";
            this.Text = "Gerir Beneficiários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.TextBox txtUltimoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDepto;
        private System.Windows.Forms.Button btnGerirCategoria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
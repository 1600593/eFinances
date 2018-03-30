namespace eFinancesWF
{
    partial class frmMovimentoCAIXA
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
            this.dtpDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoMovimento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGerirCategoria = new System.Windows.Forms.Button();
            this.btnGerirBeneficiario = new System.Windows.Forms.Button();
            this.cboBeneficiario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGerirSubCategoria = new System.Windows.Forms.Button();
            this.cboSubCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimentos de CAIXA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data do Movimento:";
            // 
            // dtpDataMovimento
            // 
            this.dtpDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataMovimento.Location = new System.Drawing.Point(179, 86);
            this.dtpDataMovimento.MaxDate = new System.DateTime(2018, 3, 27, 0, 0, 0, 0);
            this.dtpDataMovimento.MinDate = new System.DateTime(2018, 3, 27, 0, 0, 0, 0);
            this.dtpDataMovimento.Name = "dtpDataMovimento";
            this.dtpDataMovimento.Size = new System.Drawing.Size(98, 20);
            this.dtpDataMovimento.TabIndex = 2;
            this.dtpDataMovimento.Value = new System.DateTime(2018, 3, 27, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Movimento:";
            // 
            // cboTipoMovimento
            // 
            this.cboTipoMovimento.FormattingEnabled = true;
            this.cboTipoMovimento.Location = new System.Drawing.Point(179, 54);
            this.cboTipoMovimento.Name = "cboTipoMovimento";
            this.cboTipoMovimento.Size = new System.Drawing.Size(140, 21);
            this.cboTipoMovimento.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição do Movimento: ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(179, 115);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(385, 49);
            this.txtDescricao.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(179, 174);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(217, 21);
            this.cboCategoria.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria: ";
            // 
            // btnGerirCategoria
            // 
            this.btnGerirCategoria.Location = new System.Drawing.Point(402, 176);
            this.btnGerirCategoria.Name = "btnGerirCategoria";
            this.btnGerirCategoria.Size = new System.Drawing.Size(28, 19);
            this.btnGerirCategoria.TabIndex = 9;
            this.btnGerirCategoria.Text = "...";
            this.btnGerirCategoria.UseVisualStyleBackColor = true;
            this.btnGerirCategoria.Click += new System.EventHandler(this.btnGerirCategoria_Click);
            // 
            // btnGerirBeneficiario
            // 
            this.btnGerirBeneficiario.Location = new System.Drawing.Point(521, 231);
            this.btnGerirBeneficiario.Name = "btnGerirBeneficiario";
            this.btnGerirBeneficiario.Size = new System.Drawing.Size(28, 19);
            this.btnGerirBeneficiario.TabIndex = 12;
            this.btnGerirBeneficiario.Text = "...";
            this.btnGerirBeneficiario.UseVisualStyleBackColor = true;
            this.btnGerirBeneficiario.Click += new System.EventHandler(this.btnGerirBeneficiario_Click);
            // 
            // cboBeneficiario
            // 
            this.cboBeneficiario.FormattingEnabled = true;
            this.cboBeneficiario.Location = new System.Drawing.Point(179, 231);
            this.cboBeneficiario.Name = "cboBeneficiario";
            this.cboBeneficiario.Size = new System.Drawing.Size(338, 21);
            this.cboBeneficiario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Beneficiário: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Montante: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(179, 258);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(182, 20);
            this.txtValor.TabIndex = 17;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(179, 299);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(123, 38);
            this.btnProcessar.TabIndex = 18;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(346, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 38);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "VALOR EM CAIXA:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LemonChiffon;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "1.000.000,00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGerirSubCategoria
            // 
            this.btnGerirSubCategoria.Location = new System.Drawing.Point(402, 206);
            this.btnGerirSubCategoria.Name = "btnGerirSubCategoria";
            this.btnGerirSubCategoria.Size = new System.Drawing.Size(28, 19);
            this.btnGerirSubCategoria.TabIndex = 24;
            this.btnGerirSubCategoria.Text = "...";
            this.btnGerirSubCategoria.UseVisualStyleBackColor = true;
            // 
            // cboSubCategoria
            // 
            this.cboSubCategoria.FormattingEnabled = true;
            this.cboSubCategoria.Location = new System.Drawing.Point(179, 204);
            this.cboSubCategoria.Name = "cboSubCategoria";
            this.cboSubCategoria.Size = new System.Drawing.Size(217, 21);
            this.cboSubCategoria.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sub-Categoria: ";
            // 
            // frmMovimentoCAIXA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(576, 349);
            this.Controls.Add(this.btnGerirSubCategoria);
            this.Controls.Add(this.cboSubCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerirBeneficiario);
            this.Controls.Add(this.cboBeneficiario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGerirCategoria);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoMovimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataMovimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentoCAIXA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movimentos de Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataMovimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoMovimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGerirCategoria;
        private System.Windows.Forms.Button btnGerirBeneficiario;
        private System.Windows.Forms.ComboBox cboBeneficiario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGerirSubCategoria;
        private System.Windows.Forms.ComboBox cboSubCategoria;
        private System.Windows.Forms.Label label7;
    }
}


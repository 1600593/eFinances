namespace eFinancesWF
{
    partial class frmMovimentosCAIXA
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSALDO = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTipoMovimento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEntidade = new System.Windows.Forms.ComboBox();
            this.btnGerirBeneficiario = new System.Windows.Forms.Button();
            this.cboBeneficiario = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGerirSubCategoria = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSubCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDataMovimento = new System.Windows.Forms.DateTimePicker();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnGerirCategoria = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.61111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.38889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 341);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblSALDO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimentos de CAIXA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "VALOR EM CAIXA:";
            // 
            // lblSALDO
            // 
            this.lblSALDO.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSALDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSALDO.Location = new System.Drawing.Point(450, 28);
            this.lblSALDO.Name = "lblSALDO";
            this.lblSALDO.Size = new System.Drawing.Size(192, 26);
            this.lblSALDO.TabIndex = 21;
            this.lblSALDO.Text = "0,00";
            this.lblSALDO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTipoMovimento);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboEntidade);
            this.panel2.Controls.Add(this.btnGerirBeneficiario);
            this.panel2.Controls.Add(this.cboBeneficiario);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGerirSubCategoria);
            this.panel2.Controls.Add(this.btnProcessar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboSubCategoria);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtpDataMovimento);
            this.panel2.Controls.Add(this.cboCategoria);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.btnGerirCategoria);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 272);
            this.panel2.TabIndex = 1;
            // 
            // cboTipoMovimento
            // 
            this.cboTipoMovimento.DisplayMember = "TipoMovimento";
            this.cboTipoMovimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoMovimento.FormattingEnabled = true;
            this.cboTipoMovimento.Location = new System.Drawing.Point(519, 11);
            this.cboTipoMovimento.Name = "cboTipoMovimento";
            this.cboTipoMovimento.Size = new System.Drawing.Size(123, 21);
            this.cboTipoMovimento.TabIndex = 4;
            this.cboTipoMovimento.ValueMember = "TipoId";
            this.cboTipoMovimento.SelectedIndexChanged += new System.EventHandler(this.cboTipoMovimento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Movimento:";
            // 
            // cboEntidade
            // 
            this.cboEntidade.DisplayMember = "TipoEntidade";
            this.cboEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEntidade.FormattingEnabled = true;
            this.cboEntidade.Location = new System.Drawing.Point(183, 150);
            this.cboEntidade.Name = "cboEntidade";
            this.cboEntidade.Size = new System.Drawing.Size(123, 21);
            this.cboEntidade.TabIndex = 14;
            this.cboEntidade.ValueMember = "TipoEntidadeId";
            this.cboEntidade.SelectedIndexChanged += new System.EventHandler(this.cboEntidade_SelectedIndexChanged);
            // 
            // btnGerirBeneficiario
            // 
            this.btnGerirBeneficiario.Enabled = false;
            this.btnGerirBeneficiario.Location = new System.Drawing.Point(614, 152);
            this.btnGerirBeneficiario.Name = "btnGerirBeneficiario";
            this.btnGerirBeneficiario.Size = new System.Drawing.Size(28, 19);
            this.btnGerirBeneficiario.TabIndex = 16;
            this.btnGerirBeneficiario.Text = "...";
            this.btnGerirBeneficiario.UseVisualStyleBackColor = true;
            this.btnGerirBeneficiario.Click += new System.EventHandler(this.btnGerirBeneficiario_Click);
            // 
            // cboBeneficiario
            // 
            this.cboBeneficiario.DisplayMember = "Beneficiario";
            this.cboBeneficiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeneficiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBeneficiario.FormattingEnabled = true;
            this.cboBeneficiario.Location = new System.Drawing.Point(312, 150);
            this.cboBeneficiario.Name = "cboBeneficiario";
            this.cboBeneficiario.Size = new System.Drawing.Size(296, 21);
            this.cboBeneficiario.TabIndex = 15;
            this.cboBeneficiario.ValueMember = "BeneficiarioId";
            this.cboBeneficiario.SelectedIndexChanged += new System.EventHandler(this.cboBeneficiario_SelectedIndexChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(182, 38);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(460, 49);
            this.txtDescricao.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(334, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGerirSubCategoria
            // 
            this.btnGerirSubCategoria.Location = new System.Drawing.Point(405, 125);
            this.btnGerirSubCategoria.Name = "btnGerirSubCategoria";
            this.btnGerirSubCategoria.Size = new System.Drawing.Size(28, 19);
            this.btnGerirSubCategoria.TabIndex = 12;
            this.btnGerirSubCategoria.Text = "...";
            this.btnGerirSubCategoria.UseVisualStyleBackColor = true;
            this.btnGerirSubCategoria.Click += new System.EventHandler(this.btnGerirSubCategoria_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(182, 215);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(123, 48);
            this.btnProcessar.TabIndex = 19;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição do Movimento: ";
            // 
            // cboSubCategoria
            // 
            this.cboSubCategoria.DisplayMember = "SubCategoria";
            this.cboSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubCategoria.FormattingEnabled = true;
            this.cboSubCategoria.Location = new System.Drawing.Point(182, 123);
            this.cboSubCategoria.Name = "cboSubCategoria";
            this.cboSubCategoria.Size = new System.Drawing.Size(217, 21);
            this.cboSubCategoria.TabIndex = 11;
            this.cboSubCategoria.ValueMember = "SubCategoriaId";
            this.cboSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cboSubCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data do Movimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sub-Categoria: ";
            // 
            // dtpDataMovimento
            // 
            this.dtpDataMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataMovimento.Location = new System.Drawing.Point(182, 8);
            this.dtpDataMovimento.Name = "dtpDataMovimento";
            this.dtpDataMovimento.Size = new System.Drawing.Size(123, 20);
            this.dtpDataMovimento.TabIndex = 2;
            this.dtpDataMovimento.Value = new System.DateTime(2018, 4, 29, 17, 45, 7, 355);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(182, 93);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(217, 21);
            this.cboCategoria.TabIndex = 8;
            this.cboCategoria.ValueMember = "CategoriaID";
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(182, 177);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(182, 20);
            this.txtValor.TabIndex = 18;
            // 
            // btnGerirCategoria
            // 
            this.btnGerirCategoria.Location = new System.Drawing.Point(405, 95);
            this.btnGerirCategoria.Name = "btnGerirCategoria";
            this.btnGerirCategoria.Size = new System.Drawing.Size(28, 19);
            this.btnGerirCategoria.TabIndex = 9;
            this.btnGerirCategoria.Text = "...";
            this.btnGerirCategoria.UseVisualStyleBackColor = true;
            this.btnGerirCategoria.Click += new System.EventHandler(this.btnGerirCategoria_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Montante: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Entidade: ";
            // 
            // frmMovimentosCAIXA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(662, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMovimentosCAIXA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentos de CAIXA";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSALDO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGerirSubCategoria;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSubCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDataMovimento;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnGerirCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEntidade;
        private System.Windows.Forms.Button btnGerirBeneficiario;
        private System.Windows.Forms.ComboBox cboBeneficiario;
        private System.Windows.Forms.ComboBox cboTipoMovimento;
        private System.Windows.Forms.Label label3;
    }
}
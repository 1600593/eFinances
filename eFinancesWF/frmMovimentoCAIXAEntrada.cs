using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eFinancesWF
{
    public partial class frmMovimentoCAIXAEntrada : Form
    {
        public frmMovimentoCAIXAEntrada()
        {
            InitializeComponent();
        }

        private void btnGerirBeneficiario_Click(object sender, EventArgs e)
        {
            frmBeneficiarios frm = new frmBeneficiarios();
            frm.ShowDialog();
        }

        private void btnGerirCategoria_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.ShowDialog();
        }

        private void btnGerirSubCategoria_Click(object sender, EventArgs e)
        {
            frmSubCategorias frm = new frmSubCategorias();
            frm.ShowDialog();
        }
    }
}

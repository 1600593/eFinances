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
    public partial class frmDadosBeneficiarioEmpregado : Form
    {
        public frmDadosBeneficiarioEmpregado()
        {
            InitializeComponent();
        }

        private void btnGerirCategoria_Click(object sender, EventArgs e)
        {
            frmDepartamento frm = new frmDepartamento();
            frm.ShowDialog();
        }
    }
}

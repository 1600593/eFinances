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
    public partial class frmBeneficiarios : Form
    {
        public frmBeneficiarios()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form frm;
            if ( cboTipoBeneficiario.SelectedItem.ToString() == "EMPREGADO"  )
            {
                frm = new frmDadosBeneficiarioEmpregado();
                
            } else
            {
                frm = new frmDadosBeneficiarioCliente();
            }
            frm.ShowDialog();
        }
    }
}

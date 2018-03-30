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
    public partial class frmMovimentoCAIXA : Form
    {

        eFinances.Common.IApplicationController _controller = null;

        private frmMovimentoCAIXA()
        {

        }

        public frmMovimentoCAIXA(eFinances.Common.IApplicationController Controller)
        {
            _controller = Controller;
            InitializeComponent();
        }

        private void btnGerirBeneficiario_Click(object sender, EventArgs e)
        {
            frmDadosBeneficiario frm = new frmDadosBeneficiario();
            frm.ShowDialog();
        }

        private void btnGerirCategoria_Click(object sender, EventArgs e)
        {
            
        }
    }
}

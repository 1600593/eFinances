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
    public partial class frmMovimentoCAIXASaida : Form
    {

        eFinances.Common.IApplicationController _controller = null;

        public frmMovimentoCAIXASaida()
        {
            InitializeComponent();
        }

        public frmMovimentoCAIXASaida(eFinances.Common.IApplicationController Controller)
        {
            InitializeComponent();
            _controller = Controller;
            
        }

        private void btnGerirBeneficiario_Click(object sender, EventArgs e)
        {
            frmBeneficiarios frm = new frmBeneficiarios();
            frm.ShowDialog();
        }

        private void btnGerirCategoria_Click(object sender, EventArgs e)
        {
            
        }
    }
}

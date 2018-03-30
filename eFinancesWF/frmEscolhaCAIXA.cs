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
    public partial class frmEscolhaCAIXA : Form
    {
        public frmEscolhaCAIXA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMovimentoCAIXAEntrada frm = new frmMovimentoCAIXAEntrada();
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMovimentoCAIXASaida frm = new frmMovimentoCAIXASaida();
            frm.ShowDialog();
        }
    }
}

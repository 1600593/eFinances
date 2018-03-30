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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEscolhaCAIXA frm = new frmEscolhaCAIXA();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEscolhaBANCOS frm = new frmEscolhaBANCOS();
            frm.ShowDialog();
        }
    }
}

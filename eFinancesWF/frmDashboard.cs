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

            //List<object> prms = new List<object>();
            //prms.Add(123);

            //string sqlcmd = "Select * from dbo.Categorias where categId = @p1";
            //DataSet ds = eFinances.DAL.SQLDAL.GetData(sqlcmd, prms);                    

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMovimentosCAIXA frm = new frmMovimentosCAIXA();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmEscolhaBANCOS frm = new frmEscolhaBANCOS();
            //frm.ShowDialog();
        }
    }
}

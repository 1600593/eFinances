using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using eFinances.Common;
using eFinances.App.Common;
using eFinances.App.Common.EventArgs;

namespace eFinancesWF
{
    public partial class frmMovimentosCAIXA : Form, IApplicationView
    {

        private IApplicationModel _model;
        private IApplicationController _controller;


        private frmMovimentosCAIXA()
        {
            //InitializeComponent();
        }
        
        public frmMovimentosCAIXA(IApplicationController controller)
        {            
            _controller = controller;
            _model = controller.Model;

            InitializeComponent();

        }

        public IApplicationController Controller
        {
            get
            {
                return _controller;
            }
        }

        public IApplicationModel Model
        {
            get
            {
                return _model;
            }
        }

        public event EventHandler<ButtonClickedEventArgs> OnButtonClicked;

        //public object StartForm()
        //{
        //    return this;
        //}

        public object StartForm
        {
            get
            {
                return this;
            }
        }

        public void Start()
        {
            this.Show();
        }

        public void Exit()
        {
            this.Dispose();
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

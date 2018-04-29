using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using eFinances.App.Common;
using eFinances.UI.Interfaces;
using eFinances.UI.EventArgs;
using eFinances.App.Common.EventArgs;

namespace eFinancesWF
{
    public partial class frmDashboard : Form, IApplicationView, IMainDashboardView 
    {
        private IApplicationModel _model;
        private IApplicationController _controller;

        public event EventHandler<EscolheuAnoEventArgs> OnEscolheuAno;
        public event EventHandler<EscolheuMesEventArgs> OnEscolheuMes;
        //public event EventHandler OnSelectMenuCaixa;
        public event EventHandler<ButtonClickedEventArgs> OnButtonClicked;

        private frmDashboard()
        {
            //InitializeComponent();
        }

        public frmDashboard(IApplicationController Controller)
        {
            _controller = Controller;
            _model = Controller.Model;
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

        private void button3_Click(object sender, EventArgs e)
        {
            //frmMovimentosCAIXA frm = new frmMovimentosCAIXA();
            //frm.ShowDialog();            

            ButtonClickedEventArgs a = new ButtonClickedEventArgs()
            {
                ActionName = "SHOW_CAIXA",
                ButtonText = button3.Text                
            };

            OnButtonClicked?.Invoke(this, a);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClickedEventArgs a = new ButtonClickedEventArgs()
            {
                ActionName = "SHOW_BANCOS",
                ButtonText = button1.Text
            };

            OnButtonClicked?.Invoke(this, a);
        }

        public void PopulateAnos(DataTable anos)
        {
            cboAnos.DataSource = anos;
        }

        public void PopulateMeses(DataTable meses)
        {
            cboMeses.DataSource = meses;
        }

        public void SetChartData(int chartId, DataTable chartData)
        {
            switch (chartId)
            {
                case 1:
                    chart1.DataSource = chartData;
                    break;
                case 2:
                    chart2.DataSource = chartData;
                    break;
                case 3:
                    chart3.DataSource = chartData;
                    break;
                case 4:
                    chart4.DataSource = chartData;
                    break;
                default:
                    throw new ArgumentException("Invalid Chart Id.");
            }
        }

        private void cboAnos_SelectedValueChanged(object sender, EventArgs e)
        {
            EscolheuAnoEventArgs args = new EscolheuAnoEventArgs()
            {
                Ano = int.Parse(cboAnos.SelectedValue.ToString())
            };
            // invoke it
            OnEscolheuAno?.Invoke(this, args);
        }

        private void cboMeses_SelectedValueChanged(object sender, EventArgs e)
        {
            EscolheuMesEventArgs args = new EscolheuMesEventArgs()
            {
                Mes = int.Parse(cboMeses.SelectedValue.ToString())
            };
            // invoke it
            OnEscolheuMes?.Invoke(this, args);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClickedEventArgs a = new ButtonClickedEventArgs()
            {
                ActionName = "SHOW_REPORTS",
                ButtonText = button5.Text
            };

            OnButtonClicked?.Invoke(this, a);
        }

    }
}

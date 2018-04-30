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
using eFinances.UI.Interfaces;
using eFinances.UI.EventArgs;
using eFinances.App.Common.EventArgs;

namespace eFinancesWF
{
    public partial class frmMovimentosCAIXA : Form, IApplicationView, IMovimentosCaixaView
    {

        private IApplicationModel _model;
        private IApplicationController _controller;

        public event EventHandler<ButtonClickedEventArgs> OnButtonClicked;
        public event EventHandler<EscolheuCategoriaEventArgs> OnEscolheuCategoria;
        public event EventHandler<EscolheuSubCategoriaEventArgs> OnEscolheuSubCategoria;
        public event EventHandler<EscolheuBeneficiarioEventArgs> OnEscolheuBeneficiario;
        public event EventHandler<EscolheuTipoMovimentoEventArgs> OnEscolheuTipoMovimento;
        public event EventHandler<EscolheuTipoEntidadeEventArgs> OnEscolheuTipoEntidade;
        public event EventHandler<SalvarMovimentoEventArgs> OnSalvarMovimento;

        /// <summary>
        /// 
        /// </summary>
        private frmMovimentosCAIXA()
        {
            //InitializeComponent();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        public frmMovimentosCAIXA(IApplicationController controller)
        {            
            _controller = controller;
            _model = controller.Model;

            InitializeComponent();

        }

        /// <summary>
        /// 
        /// </summary>
        public IApplicationController Controller
        {
            get
            {
                return _controller;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IApplicationModel Model
        {
            get
            {
                return _model;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public object StartForm
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            this.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Exit()
        {
            this.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void PopulateCategorias(DataTable data)
        {
            try
            {
                cboCategoria.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void PopulateSubCategorias(DataTable data)
        {
            try
            {
                cboSubCategoria.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void PopulateBeneficiario(DataTable data)
        {
            try
            {
                cboBeneficiario.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void PopulateTipoMovimento(DataTable data)
        {
            try
            {
                cboTipoMovimento.DataSource = data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void PopulateTipoEntidade(DataTable data)
        {
            try
            {
                cboEntidade.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        public void ActualizaSaldo(double valor)
        {
            lblSALDO.Text = valor.ToString("C");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerirBeneficiario_Click(object sender, EventArgs e)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs()
            {
                ActionName = "MANAGE_BENEFICIARIOS",
                ButtonText = btnGerirBeneficiario.Text,
                Data = new Dictionary<string, object>() {
                                                            { "EntidadeId", cboEntidade.SelectedValue }
                                                        }
            };

            OnButtonClicked.Invoke(this, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerirCategoria_Click(object sender, EventArgs e)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs()
            {
                ActionName = "MANAGE_CATEGORIAS",
                ButtonText = btnGerirCategoria.Text,
                Data = new Dictionary<string, object>() {
                                                            { "TipoMovimentoId", cboTipoMovimento.SelectedValue }
                                                        }
            };

            OnButtonClicked.Invoke(this, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerirSubCategoria_Click(object sender, EventArgs e)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs()
            {
                ActionName = "MANAGE_SUB_CATEGORIAS",
                ButtonText = btnGerirSubCategoria.Text,
                Data = new Dictionary<string, object>() {
                                                            { "TipoMovimentoId", cboTipoMovimento.SelectedValue },
                                                            { "CategoriaId", cboCategoria.SelectedValue }
                                                        }
            };

            OnButtonClicked.Invoke(this, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja salvar?", "Salvar Movimento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SalvarMovimentoEventArgs args = new SalvarMovimentoEventArgs()
                {
                    TipoEntidadeId = (int)cboEntidade.SelectedValue,
                    BeneficiarioId = (int)cboBeneficiario.SelectedValue,
                    CategoriaId = (int)cboCategoria.SelectedValue,
                    Data = dtpDataMovimento.Value,
                    Montante = 0,
                    Movimento = txtDescricao.Text,
                    SubCategoriaId = (int)cboSubCategoria.SelectedValue,
                    TipoMovimentoId = (int)cboTipoMovimento.SelectedValue
                };

                OnSalvarMovimento?.Invoke(this, args);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a Certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ButtonClickedEventArgs args = new ButtonClickedEventArgs()
                {
                    ActionName = "EXIT",
                    ButtonText = btnCancelar.Text,
                    Data = null
                };

                OnButtonClicked.Invoke(this, args);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTipoMovimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscolheuTipoMovimentoEventArgs args = new EscolheuTipoMovimentoEventArgs();

            char.TryParse(cboTipoMovimento.SelectedValue.ToString(), out args.TipoMovimentoId);
            args.TipoMovimento = cboTipoMovimento.SelectedText;

            OnEscolheuTipoMovimento(sender, args);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscolheuCategoriaEventArgs args = new EscolheuCategoriaEventArgs();

            int.TryParse(cboCategoria.SelectedValue.ToString(), out args.CategoriaId);  
            args.Categoria = cboCategoria.SelectedText;

            OnEscolheuCategoria?.Invoke(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscolheuSubCategoriaEventArgs args = new EscolheuSubCategoriaEventArgs();

            int.TryParse(cboCategoria.SelectedValue.ToString(), out args.CategoriaId);
            int.TryParse(cboSubCategoria.SelectedValue.ToString(), out args.SubCategoriaId);
            args.SubCategoria = cboSubCategoria.SelectedText;
           
            OnEscolheuSubCategoria?.Invoke(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEntidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscolheuTipoEntidadeEventArgs args = new EscolheuTipoEntidadeEventArgs();   
            
            char.TryParse(cboEntidade.SelectedValue.ToString(), out args.TipoEntidadeId);
            args.TipoEntidade = cboEntidade.SelectedText;          
            
            OnEscolheuTipoEntidade?.Invoke(sender, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBeneficiario_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscolheuBeneficiarioEventArgs args = new EscolheuBeneficiarioEventArgs();

            int.TryParse(cboEntidade.SelectedValue.ToString(), out args.TipoEntidadeId);
            int.TryParse(cboBeneficiario.SelectedValue.ToString(), out args.BeneficiarioId);

            args.Beneficiario = cboEntidade.SelectedText;

            OnEscolheuBeneficiario?.Invoke(sender, args);
        }

    }
}

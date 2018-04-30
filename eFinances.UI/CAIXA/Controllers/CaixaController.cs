using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.App.Common;
using eFinances.App.Common.Exceptions;
using eFinances.App.Common.EventArgs;

using eFinances.UI.Interfaces;

namespace eFinances.UI.Controllers
{
    public class CaixaController : ApplicationControllerBase   
    {
        private IMovimentosCaixaView concrete_view;

        private CaixaController() { }
        public CaixaController(IApplicationContext ctx, IApplicationModel model) : base(ctx, model)
        {
            //_ctx = ctx;
            //_model = model;            
        }

        public override void InitializeView()
        {
            try
            {
                concrete_view = (IMovimentosCaixaView)base.View;
                if ( concrete_view == null )
                    throw new MVCInvalidViewOrNotDefinedException("A View não foi definida para esse controller.");

                // Liga event handlers para os eventos gerados na view
                concrete_view.OnEscolheuBeneficiario += Concrete_view_OnEscolheuBeneficiario;
                concrete_view.OnEscolheuCategoria += Concrete_view_OnEscolheuCategoria;
                concrete_view.OnEscolheuSubCategoria += Concrete_view_OnEscolheuSubCategoria;
                concrete_view.OnEscolheuTipoEntidade += Concrete_view_OnEscolheuTipoEntidade;
                concrete_view.OnEscolheuTipoMovimento += Concrete_view_OnEscolheuTipoMovimento;

                // Invoke methods for data population
                concrete_view.ActualizaSaldo(Model.GetData<double>("SALDO_CAIXA", null));
                concrete_view.PopulateCategorias(Model.GetData<DataTable>("LISTA_CATEGORIAS", null));
                concrete_view.PopulateTipoMovimento(Model.GetData<DataTable>("LISTA_TIPO_MOVIMENTO", null));
                concrete_view.PopulateTipoEntidade(Model.GetData<DataTable>("LISTA_TIPO_ENTIDADE", null));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Concrete_view_OnEscolheuTipoMovimento(object sender, EventArgs.EscolheuTipoMovimentoEventArgs e)
        {
            try
            {
                // nao tem accao associada
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Concrete_view_OnEscolheuSubCategoria(object sender, EventArgs.EscolheuSubCategoriaEventArgs e)
        {
            try
            {
                // nao tem accao associada
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Concrete_view_OnEscolheuCategoria(object sender, EventArgs.EscolheuCategoriaEventArgs e)
        {
            try
            {
                // quando escolhemos uma categoria diferente teremos que popular as sub categorias
                object[] parameters = new object[]
                {
                    e.CategoriaId 
                };
                DataTable dt = Model.GetData<DataTable>("LISTA_SUB_CATEGORIAS", parameters);
                concrete_view.PopulateSubCategorias(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Concrete_view_OnEscolheuTipoEntidade(object sender, EventArgs.EscolheuTipoEntidadeEventArgs e)
        {
            try
            {
                // quando escolhe uma entidade diferente teremos que popular os beneficiarios
                object[] parameters = new object[]
                {
                    e.TipoEntidadeId 
                };

                DataTable dt = Model.GetData<DataTable>("LISTA_BENEFICIARIOS", parameters);
                concrete_view.PopulateBeneficiario(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Concrete_view_OnEscolheuBeneficiario(object sender, EventArgs.EscolheuBeneficiarioEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

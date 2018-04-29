using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.App.Common;
using eFinances.App.Common.Exceptions;

using eFinances.App.Common.EventArgs;

namespace eFinances.UI.Controllers
{
    public class CaixaController : ApplicationControllerBase   
    {
        //private IApplicationContext _ctx = null;
        //private IApplicationModel _model = null;
        //private IApplicationView _view = null;

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
                //IMainDashboardView concrete_view = (IMainDashboardView)base.View;

                //// concrete view event handlers
                //concrete_view.PopulateAnos(base.Model.GetData<DataTable>("LISTA_ANOS", null));
                //concrete_view.PopulateMeses(base.Model.GetData<DataTable>("LISTA_MESES", null));

                //concrete_view.SetChartData(1, base.Model.GetData<DataTable>("FLUXO_CAIXA_SEMANAL", null));
                //concrete_view.SetChartData(3, base.Model.GetData<DataTable>("CAIXA_ENTRADA_TOP3", null));
                //concrete_view.SetChartData(2, base.Model.GetData<DataTable>("FLUXO_CAIXA_MENSAL", null));
                //concrete_view.SetChartData(4, base.Model.GetData<DataTable>("CAIXA_SAIDA_TOP3", null));

                //// Liga event handlers para os eventos gerados na view
                //concrete_view.OnEscolheuAno += Concrete_view_OnEscolheuAno;
                //concrete_view.OnEscolheuMes += Concrete_view_OnEscolheuMes;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.App.Common;
using eFinances.App.Common.Exceptions;
using eFinances.UI.EventArgs;
using eFinances.UI.Interfaces;
using eFinances.App.Common.EventArgs;

namespace eFinances.UI.Controllers
{
    public class MainController : ApplicationControllerBase
    {

        private MainController() : base()
        {

        }

        public MainController(IApplicationContext ctx, IApplicationModel model) : base(ctx, model)
        {

        }

        public override void InitializeView()
        {
            try
            {
                IMainDashboardView concrete_view = (IMainDashboardView)base.View;

                // concrete view event handlers
                concrete_view.PopulateAnos(base.Model.GetData<DataTable>("LISTA_ANOS", null));
                concrete_view.PopulateMeses(base.Model.GetData<DataTable>("LISTA_MESES", null));

                concrete_view.SetChartData(1, base.Model.GetData<DataTable>("FLUXO_CAIXA_SEMANAL", null));
                concrete_view.SetChartData(3, base.Model.GetData<DataTable>("CAIXA_ENTRADA_TOP3", null));
                concrete_view.SetChartData(2, base.Model.GetData<DataTable>("FLUXO_CAIXA_MENSAL", null));                
                concrete_view.SetChartData(4, base.Model.GetData<DataTable>("CAIXA_SAIDA_TOP3", null));

                // Liga event handlers para os eventos gerados na view
                concrete_view.OnEscolheuAno += Concrete_view_OnEscolheuAno;
                concrete_view.OnEscolheuMes += Concrete_view_OnEscolheuMes;

            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        private void Concrete_view_OnEscolheuMes(object sender, EscolheuMesEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Concrete_view_OnEscolheuAno(object sender, EscolheuAnoEventArgs e)
        {
            //throw new NotImplementedException();
        }

    }
}

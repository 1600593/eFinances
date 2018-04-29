using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.UI.EventArgs;

namespace eFinances.UI.Interfaces
{
       
    public interface IMainDashboardView
    {
        void PopulateAnos(DataTable anos);
        void PopulateMeses(DataTable meses);
        void SetChartData(int chartId, DataTable chartData);

        // eventos
        event EventHandler<EscolheuAnoEventArgs> OnEscolheuAno;
        event EventHandler<EscolheuMesEventArgs> OnEscolheuMes;

        //event EventHandler<ButtonClickedEventArgs> OnButtonClicked;        

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common;
using eFinances.App.Common.EventArgs;

namespace eFinances.UI.Models
{
    public class CaixaModel : IApplicationModel
    {
        public event EventHandler<DataChangedEventArgs> OnDataChanged;

        public T GetData<T>(string ActionId, object[] parameters)
        {
            switch (ActionId)
            {
                //case "FLUXO_CAIXA_SEMANAL":
                //    return (T)(object)getFluxoCaixaSemanalChartData(parameters);

                //case "FLUXO_CAIXA_MENSAL":
                //    return (T)(object)getFluxoCaixaMensalChartData(parameters);

                //case "CAIXA_ENTRADA_TOP3":
                //    return (T)(object)getCaixaEntradaTop3ChartData(parameters);

                //case "CAIXA_SAIDA_TOP3":
                //    return (T)(object)getCaixaSaidaTop3ChartData(parameters);

                //case "LISTA_ANOS":
                //    return (T)(object)getListaAnos(parameters);

                //case "LISTA_MESES":
                //    return (T)(object)getListaMeses(parameters);
                default:
                    throw new ArgumentNullException("Invalid ActionId");
            }
        }

        public bool DeleteData(string ActionId, object[] parameters)
        {
            try
            {
                DataChangedEventArgs e = new DataChangedEventArgs
                {
                    ActionId = ActionId,
                    ChangedData = parameters
                };

                OnDataChanged?.Invoke(this, e);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool InsertData(string ActionId, object[] parameters)
        {
            try
            {
                DataChangedEventArgs e = new DataChangedEventArgs
                {
                    ActionId = ActionId,
                    ChangedData = parameters
                };

                OnDataChanged?.Invoke(this, e);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveData(string ActionId, object[] parameters)
        {
            try
            {
                DataChangedEventArgs e = new DataChangedEventArgs
                {
                    ActionId = ActionId,
                    ChangedData = parameters
                };

                OnDataChanged?.Invoke(this, e);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateData(string ActionId, object[] parameters)
        {
            try
            {
                DataChangedEventArgs e = new DataChangedEventArgs
                {
                    ActionId = ActionId,
                    ChangedData = parameters
                };

                OnDataChanged?.Invoke(this, e);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

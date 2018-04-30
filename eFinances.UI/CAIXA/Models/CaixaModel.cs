using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

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
                case "SALDO_CAIXA":
                    return (T)(object)getSaldoCaixa(parameters);

                case "LISTA_CATEGORIAS":
                    return (T)(object)getListaCategorias(parameters);

                case "LISTA_SUB_CATEGORIAS":
                    return (T)(object)getListaSubCategorias(parameters);

                case "LISTA_TIPO_MOVIMENTO":
                    return (T)(object)getListaTipoMovimento(parameters);

                case "LISTA_TIPO_ENTIDADE":
                    return (T)(object)getListaTipoEntidade(parameters);

                case "LISTA_BENEFICIARIOS":
                    return (T)(object)getListaBeneficiarios(parameters);

                //case "LISTA_MESES":
                //    return (T)(object)getListaMeses(parameters);
                default:
                    throw new ArgumentNullException($"Invalid ActionId: {ActionId}");
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

        private double getSaldoCaixa(object[] parameters)
        {
            int rnd = new Random().Next(100000);
            return (double)rnd;
        }

        private object getListaCategorias(object[] parameters)
        {
            try
            {
                eFinances.BusinessLayer.CategoriasBL categ = new BusinessLayer.CategoriasBL();
                return categ.GetCategorias();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private object getListaSubCategorias(object[] parameters)
        {
            try
            {
                eFinances.BusinessLayer.SubCategoriasBL categ = new BusinessLayer.SubCategoriasBL();
                return categ.GetSubCategorias(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object getListaTipoEntidade(object[] parameters)
        {
            try
            {
                eFinances.BusinessLayer.TipoEntidadeBL entidade = new BusinessLayer.TipoEntidadeBL();
                return entidade.GetTipoEntidades();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object getListaTipoMovimento(object[] parameters)
        {
            try
            {
                eFinances.BusinessLayer.TipoMovimentoBL mov = new BusinessLayer.TipoMovimentoBL();
                return mov.GetTipoMovimentos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private object getListaBeneficiarios(object[] parameters)
        {
            try
            {
                eFinances.BusinessLayer.BeneficiariosBL beneficiarios = new BusinessLayer.BeneficiariosBL();
                return beneficiarios.GetBeneficiarios(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

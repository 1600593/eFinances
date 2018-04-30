using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using eFinances.BusinessLayer.Remote.Services.Clientes;
using eFinances.BusinessLayer.Remote.Services.Empregados;

namespace eFinances.BusinessLayer
{
    public class BeneficiariosBL
    {
        public DataTable GetBeneficiarios(object[] parameters )
        {
            try
            {
                string tipo = "";
                DataTable dtResult;
                DataTable dtReturn = getBenefitTable();
                if (parameters == null || parameters.Length == 0)
                {
                    throw new ArgumentException("Não foi indicado o Tipo de Entidade.");
                }

                tipo = parameters[0].ToString();

                switch (tipo)
                {
                    case "E":
                        dtResult = getEmpregados();
                        break;
                    case "C":
                        dtResult = getClientes();
                        break;
                    default:
                        throw new ArgumentException($"O Tipo de Beneficiario não é válido: {tipo}");
                }

                if ( dtResult == null )
                {
                    return null;
                }

                // adapt the tables interfaces...
                foreach (DataRow drResult in dtResult.Rows)
                {
                    DataRow dr = dtReturn.NewRow();
                    dr["BeneficiarioId"] = drResult[0];
                    dr["Beneficiario"] = $"{drResult[1]} {drResult[2]}";
                    dtReturn.Rows.Add(dr);
                }

                dtReturn.AcceptChanges();

                return dtReturn;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable getBenefitTable()
        {
            DataTable dt = new DataTable("Beneficiarios");
            dt.Columns.Add(new DataColumn("BeneficiarioId", typeof(int)));
            dt.Columns.Add(new DataColumn("Beneficiario", typeof(string)));

            dt.AcceptChanges();

            return dt;

        }

        private DataTable getClientes()
        {
            try
            {
                DataTable results;
                ClientesServiceClient service = new ClientesServiceClient();
                results = service.GetClientes();
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable getEmpregados()
        {
            try
            {
                DataTable results;
                EmpregadosServiceClient service = new EmpregadosServiceClient();
                results = service.GetEmpregados();
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

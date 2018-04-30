using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.BusinessLayer.Remote.Services.Empregados;

namespace eFinances.BusinessLayer
{
    public class Empregados
    {
        public DataTable ObtemEmpregados()
        {
            try
            {
                EmpregadosServiceClient client = new EmpregadosServiceClient();
                DataTable results = client.GetEmpregados();

                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

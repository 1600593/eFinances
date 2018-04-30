using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eFinances.DataLayer
{
    public class TipoMovimentoDL
    {
        public DataTable GetTipoMovimentos(object[] parametros)
        {
            try
            {
                DataSet ds;
                string sqlcode = "select TipoId, TipoMovimento from Tipos order by TipoMovimento";

                ds = DAL.SQLDAL.GetData(sqlcode, parametros);

                if (ds != null && ds.Tables.Count == 0)
                {
                    return null;
                }
                else
                {
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eFinances.DataLayer
{
    public class CategoriasDL
    {
        public DataTable GetCategorias(object[] parametros)
        {
            try
            {
                DataSet ds;
                string sqlcode = "select categoriaId, Categoria from Categorias order by Categoria";

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

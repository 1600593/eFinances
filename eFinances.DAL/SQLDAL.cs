using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using eFinances.Common;


namespace eFinances.DAL
{
    public static class SQLDAL
    {
        public static DataSet GetData(string SQLCode, List<Object> Parametros)
        {
            try
            {

                DataSet ds = new DataSet();

                string connStr = getDBConnection();

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand sqlCmd = new SqlCommand(SQLCode, conn))
                    {
                        if (Parametros != null)
                        {
                            int p = 1;
                            foreach (var item in Parametros)
                            {
                                SqlParameter sqlParam = new SqlParameter("@p" + p.ToString(), item);
                                sqlCmd.Parameters.Add(sqlParam);
                                p++;
                            }
                        }

                        using (SqlDataAdapter adp = new SqlDataAdapter(sqlCmd))
                        {
                            adp.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T GetValue<T>(string SQLCode, List<Object> Parametros)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static string getDBConnection()
        {
            try
            {
                return ConfigurationHelper<string>.GetValue("SQLDBConnection");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
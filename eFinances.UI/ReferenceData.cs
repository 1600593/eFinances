using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace eFinances.UI
{
    public class ReferenceData
    {
        DataSet ds = new DataSet();
        
        public ReferenceData()
        {
            try
            {
                ds.ReadXml(@"REFERENCE_DATA.xml");
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public DataTable Meses()
        {
            try
            {
                return ds.Tables["Mes"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public DataTable Anos()
        {
            try
            {
                return ds.Tables["Ano"];
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable Chart1()
        {
            try
            {
                return ds.Tables["Chart1"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Chart2()
        {
            try
            {
                return ds.Tables["Chart2"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Chart3()
        {
            try
            {
                return ds.Tables["Chart3"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Chart4()
        {
            try
            {
                return ds.Tables["Chart4"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.DataLayer;

namespace eFinances.BusinessLayer
{
    public class SubCategoriasBL
    {
        public DataTable GetSubCategorias(object[] parameters)
        {
            try
            {
                SubCategoriasDL categ = new SubCategoriasDL();
                return categ.GetSubCategorias(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

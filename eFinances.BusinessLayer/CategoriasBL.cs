using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.DataLayer;

namespace eFinances.BusinessLayer
{
    public class CategoriasBL
    {
        public DataTable GetCategorias()
        {
            try
            {
                CategoriasDL categ = new CategoriasDL();
                return categ.GetCategorias(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}

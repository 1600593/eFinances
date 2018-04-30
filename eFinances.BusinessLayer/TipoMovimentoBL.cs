using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.DataLayer;

namespace eFinances.BusinessLayer
{
    public class TipoMovimentoBL
    {
        public DataTable GetTipoMovimentos()
        {
            try
            {
                TipoMovimentoDL tipo = new TipoMovimentoDL();
                return tipo.GetTipoMovimentos(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
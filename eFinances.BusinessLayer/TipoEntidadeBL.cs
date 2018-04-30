using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using eFinances.DataLayer;

namespace eFinances.BusinessLayer
{
    public class TipoEntidadeBL
    {
        public DataTable GetTipoEntidades()
        {
            try
            {
                TipoEntidadeDL entidade = new TipoEntidadeDL();
                return entidade.GetTipoEntidades(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using eFinances.BusinessLayer.Remote.Services.Clientes;

namespace eFinances.BusinessLayer
{

    public class Clientes
    {
        public DataTable ObtemClientes()
        {
            try
            {
                ClientesServiceClient client = new ClientesServiceClient();
                DataTable results = client.GetClientes();

                return results;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}


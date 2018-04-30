using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using eFinances.ServiceLayer.DataContracts;
using eFinances.ServiceLayer.ServiceContracts;
using eFinances.ServiceLayer.Exceptions;

namespace eFinances.ServiceLayer
{
    public class ClienteService : IClientesService
    {
        public Cliente GetCliente(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetClientes()
        {
            try
            {
                DataSet ds = new DataSet();

                string file_path = eFinances.Common.ConfigurationHelper<string>.GetValue("DATA_FILE_PATH");
                string filename = eFinances.Common.FileUtils.CombinePath(file_path, "Clientes.xml");

                if (  System.IO.File.Exists(filename)  )
                {
                    ds.ReadXml(filename);

                    if (ds.Tables.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return ds.Tables[0];
                    }
                }
                else
                {
                    throw new DataFileNotFoundException($"O ficheiro de clientes: {filename} não foi encontrado. ");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


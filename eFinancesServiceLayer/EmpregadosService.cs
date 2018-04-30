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
    public class EmpregadosService : IEmpregadosService
    {
        public Cliente GetEmpregado(int Id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetEmpregados()
        {
            try
            {
                DataSet ds = new DataSet();
                string file_path = eFinances.Common.ConfigurationHelper<string>.GetValue("DATA_FILE_PATH");
                string filename = eFinances.Common.FileUtils.CombinePath(file_path, "Empregados.xml");

                if (System.IO.File.Exists(filename))
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
                    throw new DataFileNotFoundException($"O ficheiro de empregados: {filename} não foi encontrado. ");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
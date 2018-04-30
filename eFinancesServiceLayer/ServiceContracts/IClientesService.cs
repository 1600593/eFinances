using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;

using eFinances.ServiceLayer.DataContracts;

namespace eFinances.ServiceLayer.ServiceContracts
{
    [ServiceContract]
    public interface IClientesService
    {
        [OperationContract]
        DataTable GetClientes();

        [OperationContract]
        Cliente GetCliente(int Id);
    }
}

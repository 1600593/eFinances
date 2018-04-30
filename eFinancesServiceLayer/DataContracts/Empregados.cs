using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;

namespace eFinances.ServiceLayer.DataContracts
{
    [DataContract]
    public class Empregado
    {

        private int _empId;
        private string pnome;
        private string unome;
        private string telef;
        private string email;
        private int depid;

        [DataMember]
        public int EmpregadoId
        {
            get
            {
                return _empId;
            }
            set
            {
                _empId = value;
            }
        }

        [DataMember]
        public string PrimeiroNome
        {
            get
            {
                return unome;
            }
            set
            {
                unome = value;
            }
        }

        [DataMember]
        public string UltimoNome
        {
            get
            {
                return pnome;
            }
            set
            {
                pnome = value;
            }
        }

        [DataMember]
        public string Telefone
        {
            get
            {
                return telef;
            }
            set
            {
                telef = value;
            }
        }

        [DataMember]
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        [DataMember]
        public int DepartmentId
        {
            get
            {
                return depid;
            }
            set
            {
                depid = value;
            }
        }

    }
}

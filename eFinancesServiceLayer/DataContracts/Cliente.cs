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
    public class Cliente
    {

        private int _clientId;
        private string pnome;
        private string unome;
        private string telef;
        private string email;
        private int empid;

        [DataMember]
        public int ClienteId
        {
            get
            {
                return _clientId;
            }
            set
            {
                _clientId = value;
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
        public int EmpresaId
        {
            get
            {
                return empid;
            }
            set
            {
                empid = value;
            }
        }

    }
}

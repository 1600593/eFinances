using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.UI.EventArgs
{
    public class EscolheuBeneficiarioEventArgs : System.EventArgs
    {
        public int TipoEntidadeId;
        public int BeneficiarioId;
        public string Beneficiario;
    }
}

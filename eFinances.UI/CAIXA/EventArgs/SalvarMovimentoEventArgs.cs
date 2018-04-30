using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.UI.EventArgs
{
    public class SalvarMovimentoEventArgs : System.EventArgs
    {
        public DateTime Data;
        public int TipoMovimentoId;
        public string Movimento;
        public int CategoriaId;
        public int SubCategoriaId;
        public int TipoEntidadeId;
        public int BeneficiarioId;
        public double Montante;
    }
}

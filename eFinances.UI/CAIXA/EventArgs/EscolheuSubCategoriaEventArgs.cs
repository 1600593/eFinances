using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.UI.EventArgs
{
    public class EscolheuSubCategoriaEventArgs : System.EventArgs
    {
        public int CategoriaId;
        public int SubCategoriaId;
        public string SubCategoria;
    }
}

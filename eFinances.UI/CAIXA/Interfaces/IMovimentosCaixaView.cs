using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using eFinances.UI.EventArgs;

namespace eFinances.UI.Interfaces
{
    public interface IMovimentosCaixaView
    {

        void PopulateTipoMovimento(DataTable data);
        void PopulateTipoEntidade(DataTable data);

        void PopulateCategorias(DataTable data);
        void PopulateSubCategorias(DataTable data);
        void PopulateBeneficiario(DataTable data);

        void ActualizaSaldo(double valor);

        // eventos
        event EventHandler<EscolheuCategoriaEventArgs> OnEscolheuCategoria;
        event EventHandler<EscolheuSubCategoriaEventArgs> OnEscolheuSubCategoria;
        event EventHandler<EscolheuBeneficiarioEventArgs> OnEscolheuBeneficiario;
        event EventHandler<EscolheuTipoMovimentoEventArgs> OnEscolheuTipoMovimento;
        event EventHandler<EscolheuTipoEntidadeEventArgs> OnEscolheuTipoEntidade;
        event EventHandler<SalvarMovimentoEventArgs> OnSalvarMovimento;

    }
}

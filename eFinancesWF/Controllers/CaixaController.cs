using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common;

namespace eFinancesWF
{
    public class CaixaController : IApplicationController
    {
        IApplicationModel _model = null;
        public void AssignModel(IApplicationModel Model)
        {
            _model = Model;
        }

        public IApplicationModel Model
        {
            get
            {
                return _model;
            }
        }

    }
}

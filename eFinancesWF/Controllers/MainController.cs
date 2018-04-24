using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common;

namespace eFinancesWF.Controllers
{
    public class MainController : IApplicationController
    {
        private IApplicationModel _model = null;

        public IApplicationModel Model => _model;

        public void AssignModel(IApplicationModel model)
        {
            _model = model;
        }
    }
}

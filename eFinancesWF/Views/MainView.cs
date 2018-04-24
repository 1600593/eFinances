using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common;

namespace eFinancesWF.Views
{
    public class MainView : IApplicationView
    {

        private IApplicationController _controller;
        private IApplicationModel _model;

        public void AssignController(IApplicationController controller)
        {
            _controller = controller;
            _model = controller.Model;
        }

        public object Show()
        {
            return new frmDashboard();
        }
    }
}

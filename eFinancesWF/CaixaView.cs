﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.Common;

namespace eFinancesWF
{
    public class CaixaView : IApplicationView
    {
        IApplicationController _controller = null;
        public void AssignController(IApplicationController controller)
        {
            _controller = controller;
        }

        public object Show()
        {
            return new frmMovimentoCAIXA(_controller);
        }
    }
}
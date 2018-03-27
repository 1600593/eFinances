using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.Common
{
    public interface IApplicationView
    {
        void AssignController(IApplicationController controller);
        object Show();
    }
}

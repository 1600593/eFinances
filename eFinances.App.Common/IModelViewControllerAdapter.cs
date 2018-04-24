using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common
{
    public interface IModelViewControllerAdapter
    {
        IApplicationController Controller { get; set;  }
        IApplicationModel Model { get; set; }
        IApplicationView View { get; set;  }

        void Initialize();
        IApplicationData ExecuteAction();
    }
}

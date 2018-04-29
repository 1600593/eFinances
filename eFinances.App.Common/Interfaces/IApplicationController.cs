using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common
{
    public interface IApplicationController
    {
        IApplicationModel Model { get; }
        IApplicationContext Context { get; }
        IApplicationView View { get; set; }
        //void InitializeView();

        //Delegate OnButtonClickedDelegate(object sender, App.Common.EventArgs.ButtonClickedEventArgs e);

    }
}

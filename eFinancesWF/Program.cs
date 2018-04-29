using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using eFinances.Common;
using eFinances.App.Common;

namespace eFinancesWF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            string action = "MAINMENU";
            IApplicationContext ctx = new ContextBase();
           
            IModelViewControllerManager mvcManager = ApplicationFactory.GetInstance(ctx, action);

            Application.Run((System.Windows.Forms.Form)mvcManager.View.StartForm);
        }

    }
}

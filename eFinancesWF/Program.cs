using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using eFinances.Common;

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

            IApplicationContext ctx = new ContextBase();

            string action = "AddMovimentoCaixa";

            IModelViewControllerAdapter adapter = ApplicationFactory.GetInstance(ctx, action);
            Application.Run( (System.Windows.Forms.Form)adapter.View.Show() );

        }
    }

    public class ContextBase : IApplicationContext
    {
        private EnvironmentEnum _environment;

        public ContextBase()
        {
            switch (ConfigurationHelper<string>.GetValue("Environment").ToLower())
            {
                case "windows":
                    _environment = EnvironmentEnum.Windows;
                    break;

                case "web":
                    _environment = EnvironmentEnum.Web;
                    break;

                default:
                    throw new NotImplementedException("Environment not recognized or not implemented !!!");
            }
        }

        public EnvironmentEnum Environment => _environment;

    }




}

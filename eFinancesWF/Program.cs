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

            IApplicationController caixa_controller = ApplicationFactory<IApplicationController>.GetInstance(ctx, action);
            IApplicationModel caixa_model = ApplicationFactory<IApplicationModel>.GetInstance(ctx, action);
            IApplicationView caixa_view = ApplicationFactory<IApplicationView>.GetInstance(ctx, action);

            caixa_controller.AssignModel(caixa_model);
            caixa_view.AssignView(caixa_view);

            caixa_view.Show();

            Application.Run();

            Application.Run(new frmMovimentoCAIXA());
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

    public enum EnvironmentEnum 
    {
        Windows,
        Web,
        WebMobile,
        IOS,
        Android
    }

    public interface IApplicationContext
    {
        EnvironmentEnum Environment { get; }
    }

    public interface IApplicationController
    {
        void AssignModel(IApplicationModel caixa_model);
    }

    public interface IApplicationModel
    {

    }

    public interface IApplicationView
    {
        void AssignView(IApplicationView caixa_view);
        void Show();
    }

    public static class ApplicationFactory<T>
    {
        public static T GetInstance(IApplicationContext ctx, string Action)
        {
            throw new NotImplementedException();
        }
    }


}

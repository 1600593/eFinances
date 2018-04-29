using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common;
using eFinances.App.Common.Exceptions;
using eFinances.App.Common.EventArgs;

namespace eFinances.UI.Views
{
    public class CaixaView : ApplicationViewBase
    {

        private CaixaView() : base() {}

        public CaixaView(IApplicationController controller) : base(controller)
        {
        }

        public override IApplicationView CreateConcreteView()
        {
            try
            {
                string viewClassName = "";

                if (_controller == null)
                    throw new MVCControllerNotDefinedException("MainViewController not assigned or defined.");

                switch (_controller.Context.Environment)
                {
                    case EnvironmentEnum.Windows:
                        // TODO: obter o nome da class do concrete view do ficheiro de configuracao
                        viewClassName = "eFinancesWF.frmMovimentosCAIXA, eFinancesWF";
                        return base.LaunchView(viewClassName);

                    case EnvironmentEnum.Web:
                        throw new MVCViewNotSupportedException("No valid Web concrete view available.");

                    case EnvironmentEnum.WebMobile:
                        throw new MVCViewNotSupportedException("No valid WebMobile concrete view available.");

                    case EnvironmentEnum.IOS:
                        throw new MVCViewNotSupportedException("No valid IOS view available.");

                    case EnvironmentEnum.Android:
                        throw new MVCViewNotSupportedException("No valid Android view available.");

                    default:
                        throw new MVCViewNotSupportedException("No valid view available.");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

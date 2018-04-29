using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.Common;

namespace eFinances.App.Common
{
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.Common
{
    public static class ConfigurationHelper<T>
    {
        public static T GetValue(string Key)
        {
            try
            {
                System.Configuration.AppSettingsReader reader = new System.Configuration.AppSettingsReader();
                return (T)reader.GetValue(Key, new object().GetType());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

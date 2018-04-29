using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using eFinances.App.Common.EventArgs;

namespace eFinances.App.Common
{
    public interface IApplicationModel
    {
        T GetData<T>(string ActionId, object[] parameters);
        bool InsertData(string ActionId, object[] parameters);
        bool UpdateData(string ActionId, object[] parameters);
        bool DeleteData(string ActionId, object[] parameters);
        event EventHandler<DataChangedEventArgs> OnDataChanged;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common.EventArgs
{
    public class DataChangedEventArgs : System.EventArgs
    {
        public string ActionId { get; set; }
        public object ChangedData { get; set; }
    }
}

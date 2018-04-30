using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common.EventArgs
{
    public class ButtonClickedEventArgs : System.EventArgs
    {
        public string ActionName;
        public string ButtonText;
        //public object[] Data;
        public Dictionary<string, object> Data; //= new Dictionary<string, object>();
    }
}

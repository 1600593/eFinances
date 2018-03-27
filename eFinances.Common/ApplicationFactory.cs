using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.Common
{
    public static class ApplicationFactory<T>
    {
        public static T GetInstance(IApplicationContext ctx, string Action)
        {
            throw new NotImplementedException();
        }
    }
}

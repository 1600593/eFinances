﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common
{
    public interface IApplicationContext
    {
        EnvironmentEnum Environment { get; }
    }
}

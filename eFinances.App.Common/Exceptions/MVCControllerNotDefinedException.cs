using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common.Exceptions
{
    [System.Serializable]
    public class MVCControllerNotDefinedException : Exception
    {
        public MVCControllerNotDefinedException() { }
        public MVCControllerNotDefinedException(string message) : base(message) { }
        public MVCControllerNotDefinedException(string message, Exception inner) : base(message, inner) { }
        protected MVCControllerNotDefinedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFinances.App.Common.Exceptions
{
    [System.Serializable]
    public class InvalidApplicationActionException : Exception
    {
        public InvalidApplicationActionException() { }
        public InvalidApplicationActionException(string message) : base(message) { }
        public InvalidApplicationActionException(string message, Exception inner) : base(message, inner) { }
        protected InvalidApplicationActionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace eFinances.App.Common.Exceptions
{
    [System.Serializable]
    public class MVCViewNotSupportedException : Exception
    {
        public MVCViewNotSupportedException()
        {

        }

        public MVCViewNotSupportedException(string message) : base(message)
        {

        }

        public MVCViewNotSupportedException(string message, Exception inner) : base(message, inner)
        {

        }

        protected MVCViewNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}

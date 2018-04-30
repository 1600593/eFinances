using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;

namespace eFinances.App.Common.Exceptions
{
    [System.Serializable]
    public class MVCInvalidViewOrNotDefinedException : Exception
    {
        public MVCInvalidViewOrNotDefinedException()
        {

        }

        public MVCInvalidViewOrNotDefinedException(string message) : base(message)
        {

        }

        public MVCInvalidViewOrNotDefinedException(string message, Exception inner) : base(message, inner)
        {

        }

        protected MVCInvalidViewOrNotDefinedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
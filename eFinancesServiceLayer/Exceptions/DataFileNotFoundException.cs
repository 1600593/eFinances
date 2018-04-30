using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace eFinances.ServiceLayer.Exceptions
{
    [System.Serializable]
    public class DataFileNotFoundException : Exception
    {
        public DataFileNotFoundException() { }
        public DataFileNotFoundException(string message) : base(message) { }
        public DataFileNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected DataFileNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

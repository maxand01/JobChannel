using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALJobChannel
{
    [Serializable]
    public class DALException : Exception
    {
        public DALException() { }
        public DALException(string message) : base(message) { }
        public DALException(string message, Exception inner) : base(message, inner) { }
        protected DALException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

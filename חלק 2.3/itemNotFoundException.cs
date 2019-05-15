using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class itemNotFoundException : Exception
    {
        public itemNotFoundException()
        {
        }

        public itemNotFoundException(string message) : base(message)
        {
        }

        public itemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected itemNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
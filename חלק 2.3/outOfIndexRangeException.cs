using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class outOfIndexRangeException : Exception
    {
        public outOfIndexRangeException()
        {
        }

        public outOfIndexRangeException(string message) : base(message)
        {
        }

        public outOfIndexRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected outOfIndexRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
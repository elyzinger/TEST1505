using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class itemAlreadyExistExceptoin : Exception
    {
        public itemAlreadyExistExceptoin()
        {
        }

        public itemAlreadyExistExceptoin(string message) : base(message)
        {
        }

        public itemAlreadyExistExceptoin(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected itemAlreadyExistExceptoin(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
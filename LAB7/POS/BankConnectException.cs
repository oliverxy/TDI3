using System.Runtime.Serialization;

namespace PoS
{
    [Serializable]
    internal class BankConnectException : Exception
    {
        public BankConnectException()
        {
        }

        public BankConnectException(string? message) : base(message)
        {
        }

        public BankConnectException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BankConnectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
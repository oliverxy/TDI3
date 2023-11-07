using System.Runtime.Serialization;

namespace Banci
{
    [Serializable]
    internal class ConnectionsException : Exception
    {
        public ConnectionsException()
        {
        }

        public ConnectionsException(string? message) : base(message)
        {
        }

        public ConnectionsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ConnectionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
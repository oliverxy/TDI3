using System.Runtime.Serialization;

namespace Banci
{
    [Serializable]
    internal class CardException : Exception
    {
        public CardException()
        {
        }

        public CardException(string? message) : base(message)
        {
        }

        public CardException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CardException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System.Runtime.Serialization;

namespace Conturi
{
    [Serializable]
    internal class InsufficientFundsException : Exception
    {
        private const string InsufficientFundsConst= "Insufficient funds.";
        private const string InsufficientFundsTemplateConst = "Insufficient funds. {0} expected {1} found.";
        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string? message) : base(message)
        {
        }

        public InsufficientFundsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsufficientFundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
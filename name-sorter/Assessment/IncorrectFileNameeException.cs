using System;
using System.Runtime.Serialization;

namespace SortingAssessment
{
    [Serializable]
    internal class IncorrectFileNameeException : Exception
    {
        public IncorrectFileNameeException()
        {
        }

        public IncorrectFileNameeException(string message) : base(message)
        {
        }

        public IncorrectFileNameeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectFileNameeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
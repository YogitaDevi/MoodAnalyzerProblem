using System.Runtime.Serialization;

namespace MoodAnalyser
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            Null_Message,
            Empty_Message
        }
        public ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
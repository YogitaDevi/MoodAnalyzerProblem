using System.Runtime.Serialization;

namespace MoodAnalyser
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            NULL,
            EMPTY,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            EMPTY_MESSAGE,
            NULL_MESSAGE,           
        }
        public ExceptionType type;
        public static object expected;

        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
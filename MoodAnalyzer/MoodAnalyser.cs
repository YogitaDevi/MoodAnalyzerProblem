using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public object CustomException { get; private set; }

        public string analyseMood()
        {
            try
            {
                if (this.message.ToLower().Contains("Sad"))
                    return "SAD";
                else
                    if (message.Equals(" "))
                    throw new CustomException(MoodAnalyser.CustomException.ExceptionType.EMPTY, "Empty Mood");
                else if (message.Equals(null))
                    throw new CustomException(MoodAnalyser.CustomException.ExceptionType.NULL, "Mood Analysis Exception");
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new CustomException(MoodAnalyser.CustomException.ExceptionType.NULL, "Mood Analysis Exception");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

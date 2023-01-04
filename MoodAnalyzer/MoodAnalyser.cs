using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
        private string message;
        public Analyser(string message)
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
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new CustomException(MoodAnalyser.CustomException.ExceptionType.NULL, "Mood Analysis Exception");
            }
           
        }
    }
}

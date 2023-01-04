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

        public Analyser()
        {
        }

        public Analyser(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(MoodAnalyser.CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(MoodAnalyser.CustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}

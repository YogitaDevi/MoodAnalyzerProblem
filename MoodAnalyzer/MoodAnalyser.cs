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
                    throw new CustomException(MoodAnalyser.CustomException.ExceptionType.Empty_Message, "Mood should not be Empty");
                else if (message.Equals(null))
                    throw new CustomException(MoodAnalyser.CustomException.ExceptionType.Null_Message, "Mood should not be Null");
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new CustomException(MoodAnalyser.CustomException.ExceptionType.Null_Message, "Mood should not be Null");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
    }
}

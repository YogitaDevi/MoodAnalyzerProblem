using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public string analyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
                return "sad";
            else
                return "happy";
        }
    }
}

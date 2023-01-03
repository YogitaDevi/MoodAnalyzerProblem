using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string input;
        public MoodAnalyser(string input)
        {
            this.input = input;
        }

        public string AnalyzeMood()
        {
            if (this.input.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}

using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName, string message)
        {
            Type type = typeof(Analyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType);
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                
            }
        }
    }
    
}

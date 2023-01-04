using MoodAnalyser;
using MoodAnalyzer;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using static MoodAnalyzer.MoodAnalyzerFactory;

namespace AnalyzerTest
{
    [TestClass]
    public class AnalyserTest
    {
       
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parameeterized_ConstrctrutorImproper()
        {
            try
            {
                object expected = new Analyser("Happy");
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProbelm.MoodAnalyser", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new Analyser("Happy");
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProbelm.MoodAnalyr", "MoodAnalyser", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void Given_MoodAnalyser_Method_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            try
            {
                object expected = new Analyser("Happy");
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerProbelm.MoodAnalyzer", "MoodAnal", "Happy");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


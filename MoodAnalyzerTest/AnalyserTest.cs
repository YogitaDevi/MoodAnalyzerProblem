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
        public void GivenSadMessageWhenAnalyzeShouldReturnSadMood()
        {
            //Arrange
            string message = "I'm in Sad Mood";
            //Act
            Analyser analyser = new Analyser(message);
            string actual = analyser.analyseMood();
            //Assert
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenHappyMessageWhenAnalyzeShouldReturnHappyMood()
        {
            //Arrange
            string message = "I'm in Happy Mood";
            //Act
            Analyser analyser = new Analyser(message);
            string actual = analyser.analyseMood();
            //Assert
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMoodWhenAnalyseShouldThrowMoodAnalysisException()
        {
            try
            {
                Analyser mood = new Analyser("null");
                string actual = mood.analyseMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood Analysis Exception", e.Message);
            }
        }
        [TestMethod]
        public void GivenEMPTYMoodWhenAnalyseShouldThrowMoodAnalysisException()
        {
            try
            {
                Analyser mood = new Analyser("");
                string actual = mood.analyseMood();
            }
           catch (CustomException e)
            {
                Assert.AreEqual("Empty Mood", e.Message);
            }
        }
        [TestMethod]
        public void TestMethodClassNameShouldReturnMoodAnalyserObject()
        {
            object expected = new Analyser("");
            object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyser.Analyser", "Analyser");
            expected.Equals(actual);
        }
        [TestMethod]
        public void TestMethodClassNameImproperShouldThrowMoodAnalyserException()
        {
            try
            {
                object expected = new Analyser();
                object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyser.Analyser", "Analyser");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void TestMethodConstructorNameImproperShouldThrowMoodAnalyserException()
        {
            try
            {
                object expected = new Analyser();
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyser.Analyser", "Analyser");
                expected.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


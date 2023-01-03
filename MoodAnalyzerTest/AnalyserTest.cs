using MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class AnalyserTest
    {
        [TestMethod]
        public void GivenMessageWhenAnalyzeShouldReturnSadMood()
        {
            //Arrange
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(actual, "Sad");
        
        }
        [TestMethod]
        public void GivenAnyMessageWhenAnalyzeShouldReturnHappyMood()
        {
            //Arrange
            string message = "I am in Any Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}
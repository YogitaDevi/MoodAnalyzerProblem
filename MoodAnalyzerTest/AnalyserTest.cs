using MoodAnalyser;
namespace AnalyzerTest
{
    [TestClass]
    public class AnalyserTest
    {
        [TestMethod]
        public void GivenSadMessageWhenAnalyzeShouldReturnSadMood()
        {
            //Arrange
            string message = " ";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.analyseMood();
            //Assert
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenHappyMessageWhenAnalyzeShouldReturnHappyMood()
        {
            //Arrange
            string message = " ";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.analyseMood();
            //Assert
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}
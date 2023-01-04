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
                //Assert
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
    }
}

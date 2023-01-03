using MoodAnalyser;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class AnalyserTest
    {
        [TestMethod]
        public void GivenMessageWhenAnalyzeShouldReturnSadMood()
        {
            MoodAnalyzer obj = new MoodAnalyzer("I am in sad mood.");
            String actualResult = obj.analyseMood();
            Assert.AreEqual("sad", actualResult);
        }
        [TestMethod]
        public void GivenAnyMessageWhenAnalyzeShouldReturnHappyMood()
        {
            MoodAnalyzer obj = new MoodAnalyzer("I am in any mood.");
            String actualResult = obj.analyseMood();
            Assert.AreEqual("happy", actualResult);
        }
    }
}
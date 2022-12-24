using MoodAnalizer;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyserClass analyse = new MoodAnalyserClass("I am in sad Mode");
            string actualResult = analyse.AnalyseMood();
            Assert.AreEqual("Sad Mood", actualResult);
        }
    }
}
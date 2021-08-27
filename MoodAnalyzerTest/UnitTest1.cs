using NUnit.Framework;
using MoodAnalyzerProblem;
namespace MoodAnalyzerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer();
            string expected = "Sad Mood";
            string message = "I am ver Sad";           
            string mood = moodAnalyser.AnalyzeMood(message);
            Assert.AreEqual(expected, mood);
        }
    }
}
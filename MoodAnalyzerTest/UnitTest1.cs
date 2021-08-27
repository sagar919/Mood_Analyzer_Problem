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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string expected = "Sad Mood";
            string message = "I am ver Sad";           
            string mood = moodAnalyzer.AnalyzeMood(message);
            Assert.AreEqual(expected, mood);
        }

        [Test]
        public void GivenHappyMood_ShouldReturnhappy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string expected = "Happy Mood";
            string message = "I am very Happy";
            string mood = moodAnalyzer.AnalyzeMood(message);
            Assert.AreEqual(expected, mood);

        }
    }
}
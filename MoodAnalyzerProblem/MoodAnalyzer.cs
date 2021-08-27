using System;

namespace MoodAnalyzerProblem
{
    class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))            
                return "Sad Mood";
            else
                return "Happy Mood";

        }

        public static void Main(string[] args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            //string mood = moodAnalyzer.AnalyzeMood("I am Sad");
            Console.WriteLine("Enter your string");
            string mood = Console.ReadLine();
            Console.WriteLine(moodAnalyzer.AnalyzeMood(mood));
        }
        
    }
}

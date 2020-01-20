using System;

namespace KerasSentimentClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            SentimentClassification.Run();
            SentimentClassification.Predict("I hate you");
            SentimentClassification.Predict("I care about you");

            Console.ReadLine();
        }
    }
}

using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int lunchbreakDuration = int.Parse(Console.ReadLine());
            double lunchTime = lunchbreakDuration / 8.0;
            double relaxTime = lunchbreakDuration / 4.0;
            double watchingTime = lunchbreakDuration - (lunchTime + relaxTime);
            if (watchingTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(watchingTime - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(episodeDuration - watchingTime)} more minutes.");
            }
        }
    }
}
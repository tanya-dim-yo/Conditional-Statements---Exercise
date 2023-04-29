using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double newSeconds = distance * secondsPerMeter;
            double delay = Math.Floor(distance / 15.0) * 12.5;
            double totalSeconds = newSeconds + delay;
            if (totalSeconds < worldRecordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalSeconds - worldRecordSeconds:f2} seconds slower.");
            }
        }
    }
}
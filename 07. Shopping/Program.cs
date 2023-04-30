using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocardsQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());
            double videocardsSum = videocardsQuantity * 250;
            double processorsSum = (videocardsSum * 0.35) * processorsQuantity;
            double ramSum = (videocardsSum * 0.1) * ramQuantity;
            double totalSum = videocardsSum + processorsSum + ramSum;
            if (videocardsQuantity > processorsQuantity)
            {
                totalSum -= totalSum * 0.15;
            }
            if (totalSum <= budget)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}
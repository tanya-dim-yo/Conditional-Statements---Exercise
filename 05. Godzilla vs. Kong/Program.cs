using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int supers = int.Parse(Console.ReadLine());
            double costumeCost = double.Parse(Console.ReadLine());
            double decorSum = budget * 0.1; ;
            double supersSum = supers * costumeCost;
            double totalSum = decorSum + supersSum;
            if (supers > 150)
            {
                supersSum -= supersSum * 0.1;
                totalSum = decorSum + supersSum;
            }
            if (totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalSum:f2} leva left.");
            }
        }
    }
}
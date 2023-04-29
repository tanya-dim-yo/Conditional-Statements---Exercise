using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            int toysNumber = puzzles + dolls + bears + minion + truck;
            double puzzlesSum = puzzles * 2.60;
            double dollsSum = dolls * 3.0;
            double bearsSum = bears * 4.10;
            double minionSum = minion * 8.20;
            double truckSum = truck * 2.0;
            double toysSum = puzzlesSum + dollsSum + bearsSum + minionSum + truckSum;
            if (toysNumber >= 50)
            {
                toysSum -= toysSum * 0.25;
            }
            double totalSum = toysSum - (toysSum * 0.10);
            if (totalSum >= tripCost)
            {
                Console.WriteLine($"Yes! {totalSum - tripCost:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripCost - totalSum:f2} lv needed.");
            }
        }
    }
}
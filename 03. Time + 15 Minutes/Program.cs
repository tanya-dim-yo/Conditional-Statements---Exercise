using System;

namespace TimePlus15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesPlus = minutes + 15;
            if (minutesPlus < 60)
            {
                if (minutesPlus < 10)
                {
                    Console.WriteLine($"{hour}:0{minutesPlus}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutesPlus}");
                }
            }
            else
            {
                hour += 1;
                int newMinutes = minutesPlus - 60;
                if (hour <= 23)
                {
                    if (newMinutes < 10)
                    {
                        Console.WriteLine($"{hour}:0{newMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:{newMinutes}");
                    }
                }
                else
                {
                    if (newMinutes < 10)
                    {
                        Console.WriteLine($"0:0{newMinutes}");
                    }
                    else
                    {
                        Console.WriteLine($"0:{newMinutes}");
                    }
                }
            
            }
        }
    }
}
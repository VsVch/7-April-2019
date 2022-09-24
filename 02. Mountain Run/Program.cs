using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMetres = double.Parse(Console.ReadLine());

            double bonusTime = Math.Floor(distance/50);
            double sum = distance * timeForOneMetres + bonusTime*30;

            if (sum < record )
            {
                Console.WriteLine($"Yes! The new record is {sum:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No! He was {(sum-record):f2} seconds slower.");
            }



        }
    }
}

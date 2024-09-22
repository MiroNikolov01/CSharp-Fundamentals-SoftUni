using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            const int capacity = 255;
            int sum = 0;
            int litres = 0;
            for (int i = 1; i <= count; i++)
            {
                int waterIncome = int.Parse(Console.ReadLine());
                litres += waterIncome;
                if (capacity < litres)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litres -= waterIncome;
                    continue;
                }
                sum += waterIncome;
            }
            Console.WriteLine(sum);
        }
    }
}

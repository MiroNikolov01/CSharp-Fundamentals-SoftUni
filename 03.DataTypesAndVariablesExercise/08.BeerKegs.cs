using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double maxValue = double.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                string model = Console.ReadLine(); double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (maxValue < volume)
                {
                    maxValue = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}

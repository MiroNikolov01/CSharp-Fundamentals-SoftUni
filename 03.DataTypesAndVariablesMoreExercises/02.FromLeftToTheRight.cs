using System;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // work in progress!
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                long sum = 0;
                string numberString = Console.ReadLine();
                string[] split = numberString.Split(" ");
                long numOne = long.Parse(split[0]);
                long numTwo = long.Parse(split[1]);
                if (numOne > numTwo)
                {
                    while (Math.Abs(numOne) > 0)
                    {
                        sum += Math.Abs(numOne) % 10;
                        numOne /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    while (Math.Abs(numTwo) > 0)
                    {
                        sum += Math.Abs(numTwo) % 10;
                        numTwo /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}

using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool isTrue = default;
            for (int i = 1; i <= input; i++)
            {
                int sum = 0;
                int currentNum = 0;
                currentNum = i;
                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                if (isTrue)
                {
                    Console.WriteLine("{0} -> {1}", i, isTrue);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i, isTrue);
                }
            }

        }
    }
}

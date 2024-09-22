using System;

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                decimal inputNum = decimal.Parse(Console.ReadLine());
                sum += inputNum;
            }
            Console.WriteLine(sum);

        }
    }
}

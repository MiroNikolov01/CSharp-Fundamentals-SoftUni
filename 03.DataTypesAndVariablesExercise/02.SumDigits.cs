using System;
namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            int digit = int.Parse(number);
            for (int i = 0; i < number.Length; i++)
            {
                sum += digit % 10;
                digit /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

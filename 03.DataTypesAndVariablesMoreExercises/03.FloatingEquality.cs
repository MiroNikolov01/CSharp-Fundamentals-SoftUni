using System;

namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numberOneF = decimal.Parse(Console.ReadLine());
            decimal numberTwoF = decimal.Parse(Console.ReadLine());
            const decimal esp = 0.000001m;
            bool isEqual = Math.Abs(numberOneF - numberTwoF) < esp;
            if (isEqual)
            {
                Console.WriteLine(isEqual);
            }
            else
            {
                Console.WriteLine(isEqual);

            }
            
        }
    }
}

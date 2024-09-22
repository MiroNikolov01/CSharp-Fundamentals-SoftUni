using System;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //N = PokePower
            //M = Distance
            //Y = Exhaustion
            long n = long.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());
            int count = 0;
            double halfPower = n * 0.5;
            while (n >= m)
            {
                n -= m;
                count++;
                if (n == halfPower && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}

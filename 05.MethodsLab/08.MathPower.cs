using System.Numerics;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNumBase = long.Parse(Console.ReadLine());
            long secondNumPow = long.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(firstNumBase,secondNumPow));
        }
        static BigInteger MathPow(long firstBase, long secondPow)
        {
            BigInteger numberPow = (BigInteger)Math.Pow(firstBase, secondPow);
            return numberPow;
        }

    }
}

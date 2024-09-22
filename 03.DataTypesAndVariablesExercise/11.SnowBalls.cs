using System;
using System.Numerics;

namespace _11.SnowBalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowball = int.Parse(Console.ReadLine());
            BigInteger highestBall = 0;
            int snowHighest = 0;
            int timeHighest = 0;
            int qualityHighest = 0;
            for (int i = 1; i <= numberOfSnowball; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = (BigInteger)BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (highestBall < snowballValue)
                {
                    snowHighest = snowballSnow;
                    timeHighest = snowballTime;
                    qualityHighest = snowballQuality;
                    highestBall = snowballValue;
                }
            }
            Console.WriteLine($"{snowHighest} : {timeHighest} = {highestBall} ({qualityHighest})");

        }
    }
}

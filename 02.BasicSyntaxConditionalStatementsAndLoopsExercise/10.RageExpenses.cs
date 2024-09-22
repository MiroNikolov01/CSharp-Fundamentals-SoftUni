using System;
namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            decimal rageExpenses = 0;
            int keyboardCount = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                bool secondGameMouse = false;
                bool secondGameHeadSet = false;
                if (i % 2 == 0)
                {
                    secondGameHeadSet = true;
                    rageExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    secondGameMouse = true;
                    rageExpenses += mousePrice;
                }
                if (secondGameMouse && secondGameHeadSet)
                {
                    rageExpenses += keyboardPrice;
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        rageExpenses += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}

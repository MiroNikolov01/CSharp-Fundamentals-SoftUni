using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double rageExpenses = 0;
            int secondTimeKeyboard = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                bool sameGameMouse = false;
                bool sameGameHeadset = false;
                if (i % 2 == 0)
                {
                    sameGameHeadset = true;
                    rageExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    sameGameMouse = true;
                    rageExpenses += mousePrice;
                }
                if (sameGameMouse && sameGameHeadset)
                {
                    secondTimeKeyboard++;
                    rageExpenses += keyboardPrice;
                    if (secondTimeKeyboard % 2 == 0)
                    {
                        rageExpenses += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}

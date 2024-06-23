using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            int freeBelts = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }
               totalPrice = priceLightsaber * 
                ((Math.Ceiling(countOfStudents * 1.1))) + 
                priceRobes *
                (countOfStudents) +
                priceBelts * 
                (countOfStudents - freeBelts);
            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - budget:F2}lv more.");
            }

        }
    }
}

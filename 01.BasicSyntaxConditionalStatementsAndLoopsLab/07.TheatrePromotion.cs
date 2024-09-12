using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TheatrePromotion
{
                                                   
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int discount = 0;
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            switch (dayType)
            {
                case "weekday":
                    if ((age >= 0 && age <= 18 ) || (age > 64 && age <= 122))
                    {
                        discount = 12;
                    }
                    if (age > 18 && age <= 64)
                    {
                        discount = 18;
                    }
                    break;
                case "weekend":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        discount = 15;
                    }
                    if (age > 18 && age <= 64)
                    {
                        discount = 20;
                    }
                    break;
                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        discount = 5;
                    }
                    if (age > 18 && age <= 64)
                    {
                        discount = 12;
                    }
                    if (age > 64 && age <= 122)
                    {
                        discount = 10;
                    }
                    break;
            }
                    Console.WriteLine($"{discount}$");

        }
    }
}

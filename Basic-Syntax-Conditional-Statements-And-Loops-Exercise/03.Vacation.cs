using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            var totalPrice = 0.0;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday": totalPrice = countOfPeople * 8.45; break;
                        case "Saturday": totalPrice = countOfPeople * 9.80; break;
                        case "Sunday": totalPrice = countOfPeople * 10.46; break;
                    }
                    if (countOfPeople >= 30) totalPrice *= 0.85;
                    break;
                case "Business":
                    if (countOfPeople >= 100) countOfPeople -= 10;
                    switch (dayOfWeek)
                    {
                        case "Friday": totalPrice = countOfPeople * 10.90; break;
                        case "Saturday": totalPrice = countOfPeople * 15.60; break;
                        case "Sunday": totalPrice = countOfPeople * 16; break;
                    }

                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday": totalPrice = countOfPeople * 15; break;
                        case "Saturday": totalPrice = countOfPeople * 20; break;
                        case "Sunday": totalPrice = countOfPeople * 22.50; break;
                    }
                    if (countOfPeople >= 10 && countOfPeople <= 20) totalPrice *= 0.95;
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}

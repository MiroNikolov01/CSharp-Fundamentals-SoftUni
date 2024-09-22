using System;
using System.Security;
namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal price = 0;
            switch (typeOfPeople)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        price = 8.45m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 9.80m;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 10.46m;
                    }
                    if (countOfPeople >= 30)
                    {
                        price *= 0.85m;
                    }
                        break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        price = 10.90m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 15.60m;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 16m;
                    }
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                        break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        price = 15m;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 20m;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 22.50m;
                    }
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price *= 0.95m;
                    }
                    break;
            }
            decimal totalPrice = countOfPeople * price;
            Console.WriteLine($"Total price: {totalPrice:F2}");
            
        }
    }
}

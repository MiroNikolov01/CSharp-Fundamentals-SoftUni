using System;
using System.Diagnostics;
namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            decimal price = 0;
            for (int i = 1; i <= countOfOrders; i++)
            {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsuleCount = int.Parse(Console.ReadLine());
                 price = ((days * capsuleCount) * pricePerCapsule);
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
                Console.WriteLine($"Total: ${totalPrice:F2}");

        }
    }
}

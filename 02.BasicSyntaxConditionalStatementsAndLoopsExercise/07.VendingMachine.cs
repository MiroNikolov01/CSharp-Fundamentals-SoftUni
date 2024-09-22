using System;
using System.Diagnostics;
using System.Threading;
namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            decimal myBank = 0;
            while ((command = Console.ReadLine()) != "Start")
            {
                decimal coins = decimal.Parse(command);
                switch (coins)
                {
                    case 0.1m: myBank += 0.1m; break;
                    case 0.2m: myBank += 0.2m; break;
                    case 0.5m: myBank += 0.5m; break;
                    case 1: myBank += 1; break;
                    case 2: myBank += 2; break;
                    default: Console.WriteLine($"Cannot accept {coins:F2}"); break;
                }
            }
            string products = string.Empty;
            while ((products = Console.ReadLine()) != "End")
            {
                //"Nuts" with a price of 2.0
                //"Water" with a price of 0.7
                //"Crisps" with a price of 1.5
                //"Soda" with a price of 0.8
                //"Coke" with a price of 1.0

                switch (products)
                {
                    case "Nuts":
                        if (myBank >= 2.0m)
                        {
                            myBank -= 2.0m;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money"); 
                            
                        }
                        break;
                    case "Water":
                        if (myBank >= 0.7m)
                        {
                            myBank -= 0.7m;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        break;
                    case "Crisps":
                        if (myBank >= 1.5m)
                        {
                            myBank -= 1.5m;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        break;
                    case "Soda":
                        if (myBank >= 0.8m)
                        {
                            myBank -= 0.8m;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        break;
                    case "Coke":
                        if (myBank >= 1.0m)
                        {
                            myBank -= 1.0m;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                        break;
                    default: Console.WriteLine("Invalid product"); break;
                }
            }
            Console.WriteLine($"Change: {myBank:F2}");
        }
    }
}

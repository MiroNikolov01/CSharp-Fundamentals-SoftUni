using System;
using System.Xml;
namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            string game = string.Empty;
            decimal totalSpent = 0;
            while ((game = Console.ReadLine()) != "Game Time")
            {
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                switch (game)
                {
                    case "OutFall 4": 
                        if (balance >= 39.99m)
                        {
                            totalSpent += 39.99m;
                            balance -= 39.99m;
                            Console.WriteLine($"Bought {game}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "CS: OG": 
                        if (balance >= 15.99m)
                        {
                            totalSpent += 15.99m;
                            balance -= 15.99m;
                            Console.WriteLine($"Bought {game}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99m)
                        {
                            totalSpent += 19.99m;
                            balance -= 19.99m;
                            Console.WriteLine($"Bought {game}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                         break;
                    case "Honored 2":
                        if (balance >= 59.99m)
                        {
                            totalSpent += 59.99m;
                            balance -= 59.99m;
                            Console.WriteLine($"Bought {game}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                         break;
                    case "RoverWatch":
                        if (balance >= 29.99m)
                        {
                            totalSpent += 29.99m;
                            balance -= 29.99m;
                            Console.WriteLine($"Bought {game}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99m)
                        {
                            totalSpent += 39.99m;
                            balance -= 39.99m;
                            Console.WriteLine($"Bought {game}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        break;
                    default: Console.WriteLine("Not Found");break;
                }
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
        }
    }
}

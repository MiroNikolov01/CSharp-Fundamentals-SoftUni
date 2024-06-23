using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            double myMoney = 0;
            //Collecting CASH.
            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);
                switch (coins)
                {
                    case 0.1: myMoney += 0.1; break;
                    case 0.2: myMoney += 0.2; break;
                    case 0.5: myMoney += 0.5; break;
                    case 1: myMoney += 1; break;
                    case 2: myMoney += 2; break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}"); break;

                }
            }
            //Prices.
            double Nuts = 2;
            double Water = 0.7;
            double Crisps = 1.5;
            double Soda = 0.8;
            double Coke = 1;
            string products = string.Empty;
            //PURCHASES.
            while ((products = Console.ReadLine()) != "End")
            {
                switch (products)
                {
                    case "Nuts":
                        if (myMoney >= Nuts)
                        {
                            myMoney -= 2;
                            Console.WriteLine($"Purchased {products.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;

                        }
                        break;
                    case "Water":  
                        if (myMoney >= Water)
                        {
                            myMoney -= 0.7;
                            Console.WriteLine($"Purchased {products.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;

                        }
                        break;
                    case "Crisps":
                        if (myMoney >= Crisps)
                        {
                            myMoney -= 1.5;
                            Console.WriteLine($"Purchased {products.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        break;
                    case "Soda": 
                        if (myMoney >= Soda)
                        {
                            myMoney -= 0.8;
                            Console.WriteLine($"Purchased {products.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;

                        }
                        break;
                    case "Coke":
                        if (myMoney >= Coke)
                        {
                            myMoney -= 1;
                            Console.WriteLine($"Purchased {products.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product"); break;
                }
            }
            Console.WriteLine($"Change: {myMoney:F2}");
        }
    }
}


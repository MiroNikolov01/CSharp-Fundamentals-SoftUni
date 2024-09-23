using System;
using System.Xml;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string balance = "UNBALANCED";
            string checkBrackets = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                string bracket = Console.ReadLine();
                if (bracket == ")" ||
                    bracket == "(")
                {
                checkBrackets += bracket;
                }
                if (checkBrackets == "()")
                {
                    balance = "BALANCED";
                    checkBrackets = "";
                }
                else if (bracket != "(" && bracket != ")")
                {
                    continue;
                }
                else
                {
                    balance = "UNBALANCED";
                }

            }
            Console.WriteLine(balance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reverse = reverseString(username);
            string input = string.Empty;
            int count = 1;
            while ((input = Console.ReadLine()) != reverse)
            {
                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    Environment.Exit(0);
                }
                Console.WriteLine("Incorrect password. Try again.");
                count++;
            }
            Console.WriteLine($"User {username} logged in.");
        }
        static string reverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

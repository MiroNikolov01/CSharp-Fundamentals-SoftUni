using System;

namespace _01.DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] days =
            {
               "Monday",
               "Tuesday",
              "Wednesday",
               "Thursday",
               "Friday",
               "Saturday",
                "Sunday"
            };
            if (dayOfWeek < 1 || dayOfWeek > days.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[dayOfWeek - 1]);
            }
        }
    }
}

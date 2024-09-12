using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine()) + 30;
        if (minutes > 59)
        {
            hours += 1;
            minutes -= 60;
        }
        if (hours > 23)
        {
            hours = 0;
        }
        Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n2 > 10)
            {
                int result1 = n1 * n2;
                Console.WriteLine($"{n1} X {n2} = {result1}");
                return;
            }
            for (; n2 <= 10; n2++)
            {
                int result2 = n1 * n2;
                Console.WriteLine($"{n1} X {n2} = {result2}");
            }
        }
    }
}

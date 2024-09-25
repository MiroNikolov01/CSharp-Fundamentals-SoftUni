using System;
namespace _05.Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                int length = input.Length;
                int num = int.Parse(input);
                int mainD = num % 10;
                int offSet = (mainD - 2) * 3;

                if (mainD == 8 || mainD == 9)
                {
                    offSet++;
                }
                int index = (offSet + length - 1) + 97;
                if (num == 0)
                {
                    index = 32;
                }
                word += ((char)index).ToString();
            }
            Console.WriteLine(word);
        }
       
    }
}

using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                word += (char)(letters + key);
            }
            Console.WriteLine(word);
        }
    }
}

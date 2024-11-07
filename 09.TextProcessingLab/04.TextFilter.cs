using System.Text;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            foreach (string word in bannedWords)
            {
                int count = word.Length;
                string starsLength = "";

                for (int i = 0; i < count; i++)
                {
                    starsLength += "*";
                }
                sb.Replace(word, starsLength);
            }
            
            Console.WriteLine(sb);
        }
    }
}

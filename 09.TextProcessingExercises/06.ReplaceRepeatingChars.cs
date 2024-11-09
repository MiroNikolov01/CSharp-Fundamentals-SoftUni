using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = Console.ReadLine().ToList();
            StringBuilder sb = new StringBuilder();
            sb.Append(chars[0]);
            for (int i = 1; i < chars.Count; i++)
            {
                if (chars[i] != chars[i - 1])
                {
                    sb.Append(chars[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}

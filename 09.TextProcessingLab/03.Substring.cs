using System.Text;

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string removableString = Console.ReadLine();
            string inputString = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.Append(inputString);
            while (true)
            {
                result.Replace(removableString, "");
                string resultFinal = result.ToString();
                if (!resultFinal.Contains(removableString))
                {
                    break;
                }

            }
            Console.WriteLine(result);

        }
    }
}

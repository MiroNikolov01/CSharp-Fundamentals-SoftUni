using System.Text;

namespace _01.StringManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split
                    (" ", StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Translate":
                        inputString = Translate(inputString,
                            tokens[1],
                            tokens[2]);
                        break;
                    case "Includes":
                        Includes(inputString, tokens[1]);
                        break;
                    case "Start":
                        Start(inputString, tokens[1]);
                        break;
                    case "Lowercase":
                        inputString = Lowercase(inputString);
                        break;
                    case "FindIndex":
                        FindIndex(inputString, char.Parse(tokens[1]));
                        break;
                    case "Remove":
                        inputString = Remove(inputString,
                            int.Parse(tokens[1]),
                            int.Parse(tokens[2]));
                        break;
                }


            }
        }

        private static string Remove(string inputString, int startIndex, int count)
        {

            inputString = inputString.Remove(startIndex, count);
            Console.WriteLine(inputString);
            return inputString;
        }

        private static void FindIndex(string inputString, char ch)
        {
            for (int i = inputString.Length - 1; i > 0; i--)
            {
                if (inputString[i] == ch)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }

        private static string Lowercase(string inputString)
        {
            string lowerCaseString = null;
            foreach (char c in inputString)
            {
                lowerCaseString += c.ToString().ToLower();
            }
            Console.WriteLine(lowerCaseString);
            return lowerCaseString;
        }

        private static void Start(string inputString, string substring)
        {

            int substringLength = substring.Length;

            string startPoint = inputString.Substring(0, substringLength);
            if (startPoint == substring)
            {
                Console.WriteLine("True");
                return;
            }
            Console.WriteLine("False");
        }

        private static void Includes(string inputString, string substring)
        {
            if (inputString.Contains(substring))
            {
                Console.WriteLine("True");
                return;
            }
            Console.WriteLine("False");

        }

        private static string Translate(string inputString, string ch, string replacement)
        {
            StringBuilder sb = new StringBuilder(inputString);
            while (sb.ToString().Contains(ch))
            {
                sb.Replace(ch, replacement);
            }
            inputString = sb.ToString();

            Console.WriteLine(inputString);

            return inputString;
        }
    }

}



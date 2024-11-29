namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string initialString = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                int startIndex = 0;
                int endIndex = 0;
                if (tokens.Length < 2)
                {
                    continue;
                }
                switch (tokens[0])
                {
                    case "Add Stop":
                        startIndex = int.Parse(tokens[1]);
                        string insertString = tokens[2];
                        initialString = Add(startIndex,
                            insertString,
                            initialString);
                        break;
                    case "Remove Stop":
                        startIndex = int.Parse(tokens[1]);
                        endIndex = int.Parse(tokens[2]);
                        initialString = Remove(startIndex,
                            endIndex,
                            initialString);
                        break;
                    case "Switch":
                        string oldString = tokens[1];
                        string newString = tokens[2];
                        initialString = Switch(oldString,
                            newString,
                            initialString);
                        break;
                }
                Console.WriteLine(initialString);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {initialString}");
        }

        private static string Switch(string oldString, string newString, string initialString)
        {
            if (initialString.Contains(oldString))
            {
                initialString = initialString.Replace(oldString, newString);
            }

            return initialString;
        }

        private static string Remove(int startIndex, int endIndex, string initialString)
        {
            if (IsValidIndex(startIndex, initialString) && IsValidIndex(endIndex,initialString))
            {
                initialString = initialString.Remove(startIndex, endIndex - startIndex + 1);
            }

            return initialString;

        }

        private static string Add(int index, string insertString, string initialString)
        {
            if (IsValidIndex(index, initialString))
            {
                initialString = initialString.Insert(index, insertString);
            }

            return initialString;
        }

        static bool IsValidIndex(int startIndex, string initialString)
        {
            return startIndex >= 0 && startIndex <= initialString.Length - 1;
        }
    }
}

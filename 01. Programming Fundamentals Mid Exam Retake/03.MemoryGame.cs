namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();
            int moves = 0;
            string indexStr = string.Empty;
            while ((indexStr = Console.ReadLine()) != "end")
            {
                if (elements.Count == 0)
                {
                    continue;
                }
                string[] indexes = indexStr.Split();
                int indexOne = int.Parse(indexes[0]);
                int indexTwo = int.Parse(indexes[1]);
                moves++;
                if (!isValidIndexes(elements, indexOne, indexTwo))
                {
                    int middleIndex = elements.Count / 2;

                    elements.Insert(middleIndex, $"-{moves}a");
                    elements.Insert(middleIndex, $"-{moves}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (elements[indexOne] == elements[indexTwo])
                {
                    string element = elements[indexOne];
                    elements.Remove(element);
                    elements.Remove(element);
                    Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {moves} turns!");
                return;
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
        static bool isValidIndexes(List<string> list, int indexOne, int indexTwo)
        {
            return indexOne >= 0 && indexOne <= list.Count - 1 &&
                   indexTwo >= 0 && indexTwo <= list.Count - 1 &&
                   indexOne != indexTwo;
        }
    }
}

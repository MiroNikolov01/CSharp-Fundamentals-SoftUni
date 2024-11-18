namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split().
                ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        list = MergeMethod(list, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        DivideMethod(list, index, partitions);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));

        }
        static List<string> MergeMethod(List<string> list, int startIndex, int endIndex)
        {
            startIndex = Clamp(startIndex, 0, list.Count - 1);
            endIndex = Clamp(endIndex, 0, list.Count - 1);

            List<string> range = list.GetRange(startIndex, endIndex - startIndex + 1);
            string mergedStr = string.Join(string.Empty, range);
            list.RemoveRange(startIndex, endIndex - startIndex + 1);
            list.Insert(startIndex, mergedStr);

            return list;
        }
        static List<string> DivideMethod(List<string> list, int index, int partitions)
        {
            if (partitions <= 0)
            {
                return list;
            }
            string element = list[index];
            List<string> newElemets = new List<string>();

            int subLength = element.Length / partitions;
            int remainingChars = element.Length % partitions;

            int elementIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                string newString = string.Empty;
                for (int j = 0; j < subLength; j++)
                {
                    newString += element[elementIndex];
                    elementIndex++;
                }
                newElemets.Add(newString);
            }
            if (remainingChars > 0 && newElemets.Count > 0)
            {
                for (int i = elementIndex; i < element.Length; i++)
                {
                    newElemets[newElemets.Count - 1] += element[i];
                }
            }
            list.RemoveRange(index, 1);
            list.InsertRange(index, newElemets);

            return list;
        }
        static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
            }
            else if (value > max)
            {
                value = max;
            }
            return value;
        }
    }
}


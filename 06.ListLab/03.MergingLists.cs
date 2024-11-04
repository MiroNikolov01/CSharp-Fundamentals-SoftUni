namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondNumInput = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            List<int> resultList = new List<int>();
            List<int> oldResult = new List<int>(firstNumInput);

            int index = 0;
            if (firstNumInput.Count < secondNumInput.Count)
            {
                for (int i = 0; i < firstNumInput.Count; i++)
                {
                    resultList.Add(oldResult[i]);
                    resultList.Add(secondNumInput[i]);
                    index++;
                }
                secondNumInput.RemoveRange(0, index);
                resultList.InsertRange(resultList.Count, secondNumInput);
                PrintResult(resultList);

            }
            else
            {
                for (int i = 0; i < secondNumInput.Count; i++)
                {
                    resultList.Add(oldResult[i]);
                    resultList.Add(secondNumInput[i]);
                    index++;
                }
                firstNumInput.RemoveRange(0, index);
                resultList.InsertRange(resultList.Count, firstNumInput);
                PrintResult(resultList);
            }

        }
        static void PrintResult(List<int> result)
        {
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

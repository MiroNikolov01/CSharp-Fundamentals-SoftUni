namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int limit = numbersInput.Count / 2;

            for (int i = 0; i < limit; i++)
            {
                numbersInput[i] += numbersInput[numbersInput.Count - 1];
                numbersInput.RemoveAt(numbersInput.Count - 1);
            }
            foreach (var item in numbersInput)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}


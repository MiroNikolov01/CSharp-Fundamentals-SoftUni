namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNum = bombNumbers[0];
            int powerNum = bombNumbers[1];

            while (numbers.Contains(bombNum))
            {
                int index = numbers.IndexOf(bombNum);

                int leftIndex = Math.Max(index - powerNum, 0);
                int rightIndex = Math.Min(index + powerNum, numbers.Count - 1);

                int range = rightIndex - leftIndex + 1;

                numbers.RemoveRange(leftIndex, range);
            }
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}



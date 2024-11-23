namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int countShots = 0;
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string index = string.Empty;
            while ((index = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(index);
                if (!isValidIndex(targets, targetIndex))
                {
                    continue;
                }
                int currentShotNum = targets[targetIndex];
                if (targets[targetIndex] == -1)
                {
                    continue;
                }
                else
                {
                    targets[targetIndex] = -1;
                    countShots++;
                }
                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] > currentShotNum && targets[i] != -1)
                    {
                        targets[i] -= currentShotNum;
                    }
                    else if (targets[i] <= currentShotNum && targets[i] != -1)
                    {
                        targets[i] += currentShotNum;
                    }
                }
            }
            Console.Write($"Shot targets: {countShots} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
        static bool isValidIndex(int[] arr, int index)
        {
            return index >= 0 && index <= arr.Length - 1;
        }
    }
}

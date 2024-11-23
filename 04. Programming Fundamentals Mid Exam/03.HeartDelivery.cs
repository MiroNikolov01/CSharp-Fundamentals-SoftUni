namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            int houseIndex = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] length = command.Split();
                houseIndex += int.Parse(length[1]);
                if (ValidIndex(houses, houseIndex))
                {
                    if (houses[houseIndex] <= 0)
                    {
                        Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                        continue;
                    }
                    houses[houseIndex] -= 2;
                    PrintValentines(houses, houseIndex);
                }
                else
                {
                    houseIndex = 0;
                    if (houses[houseIndex] <= 0)
                    {
                        Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                        continue;
                    }
                    houses[houseIndex] -= 2;
                    PrintValentines(houses, houseIndex);

                }
            }
            int houseCount = 0;
            int wins = 0;
            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] == 0)
                {
                    wins++;
                }
                else
                {
                    houseCount++;
                }
            }
            Console.WriteLine($"Cupid's last position was {houseIndex}.");
            if (wins == houses.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
        static bool ValidIndex(List<int> list, int number)
        {
            return number >= 0 && number <= list.Count - 1;
        }
        static int PrintValentines(List<int> list, int index)
        {
            if (list[index] <= 0)
            {
                Console.WriteLine($"Place {index} has Valentine's day.");
            }

            return index;
        }
    }
}








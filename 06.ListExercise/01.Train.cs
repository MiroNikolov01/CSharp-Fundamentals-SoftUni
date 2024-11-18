namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {

                if (command.Contains('A'))
                {
                    string[] arguments = command.Split();
                    int numberAdd = int.Parse(arguments[1]);
                    AddCommand(wagons, numberAdd);
                    continue;
                }
                int passangers = int.Parse(command);
                for (int i = 0; i < wagons.Count; i++)
                {
                    int currentWagon = wagons[i];
                    bool isFree = currentWagon + passangers <= capacity;
                    if (isFree)
                    {
                        wagons[i] += passangers;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
        static void AddCommand(List<int> list, int numberAdd)
        {
            list.Add(numberAdd);
        }
    }
}


